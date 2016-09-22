package com.zeus.myfootstep;

import android.Manifest;
import android.app.Service;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.os.IBinder;
import android.support.v4.app.ActivityCompat;
import android.util.Log;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;

import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;

public class SaveToFile extends Service implements SensorEventListener {
    private SensorManager SM;
    static BlockingQueue<Data> queue = new ArrayBlockingQueue<Data>(100);
    static boolean start = false;
    protected SaveData store = null;
    private static final int WritePermission = 0x11;
    private static String[] Permissions={
            Manifest.permission.WRITE_EXTERNAL_STORAGE
    };

    public SaveToFile() {
    }

    @Override
    public void onCreate() {
        super.onCreate();
        /*SM = (SensorManager)getSystemService(SENSOR_SERVICE);
        Sensor accSensor = SM.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        Sensor gyrSensor = SM.getDefaultSensor(Sensor.TYPE_GYROSCOPE);
        boolean granted = true; // This is never used!*/
    }

    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
        // Needs to be fixed
        SM = (SensorManager)getSystemService(SENSOR_SERVICE);
        Sensor accSensor = SM.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        Sensor gyrSensor = SM.getDefaultSensor(Sensor.TYPE_GYROSCOPE);
        boolean granted = true;
        return START_STICKY; // stay running
    }

    @Override
    public IBinder onBind(Intent intent) {
        // We don't provide binding, so return null
        return null;
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
    public void onDestroy() {
        Toast.makeText(this, "service done", Toast.LENGTH_SHORT).show();
    }

    @Override
    public void onSensorChanged(SensorEvent event) {
        int type = event.sensor.getType();
        //Data data = null;
        if (type == Sensor.TYPE_ACCELEROMETER) {
            /*TextView xAcc = (TextView) findViewById(R.id.xAcceleration);
            TextView yAcc = (TextView) findViewById(R.id.yAcceleration);
            TextView zAcc = (TextView) findViewById(R.id.zAcceleration);
            TextView time = (TextView) findViewById(R.id.time);

            xAcc.setText("X: " + event.values[0]);
            yAcc.setText("Y: " + event.values[1]);
            zAcc.setText("Z: " + event.values[2]);
            time.setText("Time: " + event.timestamp);*/

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
            /*TextView xGyr = (TextView) findViewById(R.id.xGyroscope);
            TextView yGyr = (TextView) findViewById(R.id.yGyroscope);
            TextView zGyr = (TextView) findViewById(R.id.zGyroscope);

            xGyr.setText("X: " + event.values[0]);
            yGyr.setText("Y: " + event.values[1]);
            zGyr.setText("Z: " + event.values[2]);*/

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
}
