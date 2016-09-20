package com.zeus.myfootstep;

import android.content.pm.PackageManager;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.support.v4.app.ActivityCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.Manifest;
import android.util.Log;


import java.util.Date;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;


public class MainActivity extends AppCompatActivity implements SensorEventListener{
    private SensorManager SM;
    static BlockingQueue<Data> queue = new ArrayBlockingQueue<Data>(100);
    static boolean start = false;
    protected SaveData store = null;
    private static final int WritePermission = 0x11;
    private static String[] Permissions={
            Manifest.permission.WRITE_EXTERNAL_STORAGE
    };


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        SM = (SensorManager)getSystemService(SENSOR_SERVICE);
        Sensor accSensor = SM.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        Sensor gyrSensor = SM.getDefaultSensor(Sensor.TYPE_GYROSCOPE);
        boolean granted = true;


    }

    public void startCollection(View view) {
        start();
        start = true;
        store = new SaveData();
        store.start();
        if(ActivityCompat.checkSelfPermission(this, Manifest.permission.WRITE_EXTERNAL_STORAGE)
                != PackageManager.PERMISSION_GRANTED);{
            ActivityCompat.requestPermissions(this,Permissions,WritePermission);
        }


    }
    public void OnRequestPermissionsResult(int requestCode, String[] Permissions, int[] grantedResults){
        switch (requestCode){
            case WritePermission:{
                if(grantedResults.length>0
                    && grantedResults[0] == PackageManager.PERMISSION_GRANTED){
                    Log.i("MainActivity:","Granted");
                }else{
                    Log.i("MainActivity:","Denied");
                }
            }
        }
        /*if(ActivityCompat.shouldShowRequestPermissionRationale(this,
                Manifest.permission.WRITE_EXTERNAL_STORAGE)){

        }*/
    }

    public void stopCollection(View view) {
        stop();
    }

    public void start(){
        SM = (SensorManager)getSystemService(SENSOR_SERVICE);
        Sensor accSensor = SM.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        SM.registerListener(this, accSensor, SensorManager.SENSOR_DELAY_FASTEST);
        Sensor gyrSensor = SM.getDefaultSensor(Sensor.TYPE_GYROSCOPE);
        SM.registerListener(this, gyrSensor, SensorManager.SENSOR_DELAY_FASTEST);
    }

    public void stop(){
        SM.unregisterListener(this);
    }

    @Override
    public void onSensorChanged(SensorEvent event) {
        int type = event.sensor.getType();
        //Data data = null;
        if (type == Sensor.TYPE_ACCELEROMETER) {
            TextView xAcc = (TextView) findViewById(R.id.xAcceleration);
            TextView yAcc = (TextView) findViewById(R.id.yAcceleration);
            TextView zAcc = (TextView) findViewById(R.id.zAcceleration);
            TextView time = (TextView) findViewById(R.id.time);

            xAcc.setText("X: " + event.values[0]);
            yAcc.setText("Y: " + event.values[1]);
            zAcc.setText("Z: " + event.values[2]);
            time.setText("Time: " + event.timestamp);

            Data data  = new Data();
            data.label = "A";
            data.values =event.values;
            data.time= event.timestamp;
            try {
                queue.put(data);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }

        }
        if (type == Sensor.TYPE_GYROSCOPE) {
            TextView xGyr = (TextView) findViewById(R.id.xGyroscope);
            TextView yGyr = (TextView) findViewById(R.id.yGyroscope);
            TextView zGyr = (TextView) findViewById(R.id.zGyroscope);

            xGyr.setText("X: " + event.values[0]);
            yGyr.setText("Y: " + event.values[1]);
            zGyr.setText("Z: " + event.values[2]);

            Data data  = new Data();
            data.label = "G";
            data.values =event.values;
            data.time= event.timestamp;
            try {
                queue.put(data);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }



    }

    @Override
    public void onAccuracyChanged(Sensor sensor, int accuracy) {

    }
    public static void enqueue(float[] values, long time,String label){
        /*Data data;
        data.label = label;
        data.values =values;
        data.time= time;*/
    }
}
