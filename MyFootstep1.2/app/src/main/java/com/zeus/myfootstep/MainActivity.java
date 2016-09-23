package com.zeus.myfootstep;

import android.Manifest;
import android.content.BroadcastReceiver;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.pm.PackageManager;
import android.hardware.Sensor;
import android.support.v4.app.ActivityCompat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.TextView;

import java.util.Date;
import java.util.concurrent.BlockingQueue;

public class MainActivity extends AppCompatActivity {


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        IntentFilter filter = new IntentFilter();
        filter.addAction(SensorService.ACTION_FINISHED);
        registerReceiver(new MyRecieiver(), filter );
    }

    public void startCollection(View view) {
        Intent intent = new Intent(this, SensorService.class);
        startService(intent);


    }

    public void stopCollection(View view) {
        stop();
    }

    public void stop(){

    }

    private class MyRecieiver extends BroadcastReceiver{

        @Override
        public void onReceive(Context context, Intent intent) {
            int type = intent.getIntExtra("SensorType",0);
            float[] values = intent.getFloatArrayExtra("Value");
            long time = intent.getLongExtra("Time",0);
            Log.d("time", "Time of running: " + time);

            if (type == Sensor.TYPE_ACCELEROMETER) {
                TextView xAcc = (TextView) findViewById(R.id.xAcceleration);
                TextView yAcc = (TextView) findViewById(R.id.yAcceleration);
                TextView zAcc = (TextView) findViewById(R.id.zAcceleration);
                TextView timetextview = (TextView) findViewById(R.id.time);

                xAcc.setText("X: " + values[0]);
                yAcc.setText("Y: " + values[1]);
                zAcc.setText("Z: " + values[2]);
                timetextview.setText("Time: " + time);
            }

            if (type == Sensor.TYPE_GYROSCOPE) {
                TextView xGyr = (TextView) findViewById(R.id.xGyroscope);
                TextView yGyr = (TextView) findViewById(R.id.yGyroscope);
                TextView zGyr = (TextView) findViewById(R.id.zGyroscope);

                xGyr.setText("X: " + values[0]);
                yGyr.setText("Y: " + values[1]);
                zGyr.setText("Z: " + values[2]);
            }
        }
    }
}

