package com.zeus.myfootstep;

import android.app.Service;
import android.content.Intent;
import android.hardware.Sensor;
import android.hardware.SensorManager;
import android.os.Environment;
import android.os.IBinder;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.util.Log;
import android.app.IntentService;

import java.io.DataOutputStream;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;

public class SensorService extends IntentService implements SensorEventListener {
    //Data data = new Data(label, value, time);
    private int type;
    Data data;
    public static final String ACTION_FINISHED = "imfinished";
    public static BlockingQueue<Data> queue; // = new ArrayBlockingQueue<Data>(1000);
    //public static BlockingQueue<Data> recycle = new ArrayBlockingQueue<>(1000);


    public SensorService(){
        this("downloader");
    }

    public SensorService(String name) {
        super(name);
    }

    public SensorService(BlockingQueue<Data> q){
        super("downloader");
        queue =q;
    }

    @Override
    public IBinder onBind(Intent intent) {
        // TODO: Return the communication channel to the service.
        throw new UnsupportedOperationException("Not yet implemented");
    }


    @Override
    //public int onStartCommand(Intent intent, int flags, int startId) {
    protected void onHandleIntent(Intent intent){

        SensorManager SM = (SensorManager)getSystemService(SENSOR_SERVICE);
        Sensor accSensor = SM.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        SM.registerListener(this , accSensor, SensorManager.SENSOR_DELAY_FASTEST);
        Sensor gyrSensor = SM.getDefaultSensor(Sensor.TYPE_GYROSCOPE);
        SM.registerListener(this, gyrSensor, SensorManager.SENSOR_DELAY_FASTEST);
        Log.i("Sensor service: ","we register the sensor");
        SaveData SD = new SaveData(queue);
        new Thread(SD).start();


        /*Intent done = new Intent();
        done.setAction(ACTION_FINISHED);
        done.putExtra("SensorType", type );
        done.putExtra("Value", data.values);
        done.putExtra("Time", data.time);
        sendBroadcast(done);*/

        /*Thread thread = new Thread(new Runnable() {
            @Override
            public void run() {

            }
        });*/
        //return START_STICKY;


    }

    @Override
    public void onAccuracyChanged(Sensor sensor, int accuracy) {

    }

    @Override
    public void onSensorChanged(SensorEvent event) {
        type = event.sensor.getType();

        //data.time= event.timestamp;
        if (type == Sensor.TYPE_ACCELEROMETER) {
            data = new Data("A",event.values,event.timestamp);
            try {
                queue.put(data);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }

        }
        if (type == Sensor.TYPE_GYROSCOPE) {
            data = new Data("G",event.values,event.timestamp);
            try {
                queue.put(data);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }


        }
    }







}
