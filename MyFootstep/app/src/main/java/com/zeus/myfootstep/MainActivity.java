package com.zeus.myfootstep;

import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;

import java.util.Date;

public class MainActivity extends AppCompatActivity implements SensorEventListener{
    private SensorManager SM;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

    }

    public void startCollection(View view) {
        start();

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
        if (type == Sensor.TYPE_ACCELEROMETER) {
            TextView xAcc = (TextView) findViewById(R.id.xAcceleration);
            TextView yAcc = (TextView) findViewById(R.id.yAcceleration);
            TextView zAcc = (TextView) findViewById(R.id.zAcceleration);
            TextView time = (TextView) findViewById(R.id.time);

            xAcc.setText("X: " + event.values[0]);
            yAcc.setText("Y: " + event.values[1]);
            zAcc.setText("Z: " + event.values[2]);
            time.setText("Time: " + event.timestamp);

        }
        if (type == Sensor.TYPE_GYROSCOPE) {
            TextView xGyr = (TextView) findViewById(R.id.xGyroscope);
            TextView yGyr = (TextView) findViewById(R.id.yGyroscope);
            TextView zGyr = (TextView) findViewById(R.id.zGyroscope);

            xGyr.setText("X: " + event.values[0]);
            yGyr.setText("Y: " + event.values[1]);
            zGyr.setText("Z: " + event.values[2]);
        }


    }

    @Override
    public void onAccuracyChanged(Sensor sensor, int accuracy) {

    }
}
