package com.zeus.myfootstep;

import android.app.IntentService;
import android.app.Service;
import android.content.Intent;
import android.hardware.Sensor;
import android.hardware.SensorManager;
import android.os.Handler;
import android.os.IBinder;
import android.hardware.Sensor;
import android.hardware.SensorManager;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.util.Log;
import android.widget.TextView;

import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;

public class SensorService extends Service implements SensorEventListener {
    Data data = new Data();
    private int type;
    public static final String ACTION_FINISHED = "imfinished";
    BlockingQueue<Data> queue = new ArrayBlockingQueue<Data>(100);


    /*public SensorService(){
        this("downloader");
    }

    public SensorService(String name) {
        super(name);
    }*/

    @Override
    public IBinder onBind(Intent intent) {
        // TODO: Return the communication channel to the service.
        throw new UnsupportedOperationException("Not yet implemented");
    }


    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
    //protected void onHandleIntent(Intent intent){
        SensorManager SM = (SensorManager)getSystemService(SENSOR_SERVICE);
        Sensor accSensor = SM.getDefaultSensor(Sensor.TYPE_ACCELEROMETER);
        SM.registerListener(this , accSensor, SensorManager.SENSOR_DELAY_FASTEST);
        Sensor gyrSensor = SM.getDefaultSensor(Sensor.TYPE_GYROSCOPE);
        SM.registerListener(this, gyrSensor, SensorManager.SENSOR_DELAY_FASTEST);

        Intent done = new Intent();
        done.setAction(ACTION_FINISHED);
        done.putExtra("SensorType", type );
        done.putExtra("Value", data.values);
        done.putExtra("Time", data.time);
        sendBroadcast(done);
        return START_STICKY;
    }

    @Override
    public void onAccuracyChanged(Sensor sensor, int accuracy) {

    }

    @Override
    public void onSensorChanged(SensorEvent event) {
        type = event.sensor.getType();
        data.time= event.timestamp;
        if (type == Sensor.TYPE_ACCELEROMETER) {
            data.label = "A";
            data.values =event.values;
            Log.d("Values", "X acc value: " + data.values[0]);
            try {
                queue.put(data);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
        if (type == Sensor.TYPE_GYROSCOPE) {
            data.label = "G";
            data.values =event.values;
            try {
                queue.put(data);
            } catch (InterruptedException e) {
                e.printStackTrace();
            }
        }
    }

}
