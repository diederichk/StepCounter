package com.zeus.footstep;

import android.content.Context;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;

import android.hardware.Sensor;
import android.hardware.SensorManager;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.widget.TextView;

import java.io.File;
import java.io.FileOutputStream;
import java.io.IOException;
import java.util.concurrent.BlockingQueue;
import java.io.FileWriter;


public class MainActivity extends AppCompatActivity implements SensorEventListener {

    private Sensor mySensor;
    private SensorManager SM;
    private TextView xText, yText, zText;
    private long time;
    private BlockingQueue queue;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        SM = (SensorManager)getSystemService(SENSOR_SERVICE);
        mySensor = SM.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        SM.registerListener(this, mySensor, SensorManager.SENSOR_DELAY_FASTEST);

        xText = (TextView)findViewById(R.id.xAcceleration);
        yText = (TextView)findViewById(R.id.yAcceleration);
        zText = (TextView)findViewById(R.id.zAcceleration);
    }



    @Override
    public void onSensorChanged(SensorEvent event) {
        xText.setText("X: " + event.values[0]);
        yText.setText("Y: " + event.values[1]);
        zText.setText("Z: " + event.values[2]);

    }

    @Override
    public void onAccuracyChanged(Sensor sensor, int accuracy) {

    }

    public void stopCollection(View view) {

    }

    public void startCollection(View view) {
        FileWriter f;
        String filename = "/Documents/myfile.txt";
        String string = "Hello world!";
        try {
            f = new FileWriter(filename, true);
            f.append(string);
            f.flush();
            f.close();

        } catch (IOException e1) {
            e1.printStackTrace();
        }


        /*
        DiskWriter ex = new DiskWriter();
        ex.run();
*/
    }

}

class DiskWriter implements Runnable {
    BlockingQueue queue;
    FileWriter f;
    String filename = "myfile";
    String string = "Hello world!";
    boolean running = true;
    //FileOutputStream outputStream;


       // outputStream.write(string.getBytes());
        //outputStream.close();

    public void run() {
        // Open a file
        try {
            f = new FileWriter(filename, true);

        } catch (IOException e1) {
            e1.printStackTrace();
        }
        while(running){
            try {
                f.append(string);
            } catch (IOException e) {
                e.printStackTrace();
            }

            running = false;
        }

        /*
        // How to do this method
        f = open file;
        while(running) {
            b = get object from shared queue;
            write to the disk;
            put b back in the buffer pool;
        }
        close file;
        */
    }

}

