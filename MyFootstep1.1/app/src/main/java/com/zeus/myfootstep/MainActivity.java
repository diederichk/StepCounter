package com.zeus.myfootstep;

import android.content.Intent;
import android.content.pm.PackageManager;
import android.hardware.Sensor;
import android.hardware.SensorEvent;
import android.hardware.SensorEventListener;
import android.hardware.SensorManager;
import android.support.v4.app.ActivityCompat;
//import android.support.v4.media.MediaBrowserServiceCompatApi21.ServiceCallbacks;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;
import android.Manifest;
import android.util.Log;
import android.content.Context;
import android.content.ServiceConnection;
import android.content.ComponentName;
import android.os.IBinder;


import java.util.Date;
import java.util.concurrent.ArrayBlockingQueue;
import java.util.concurrent.BlockingQueue;


public class MainActivity extends AppCompatActivity{
    private SensorManager SM;
    static BlockingQueue<Data> queue = new ArrayBlockingQueue<Data>(100);
    static boolean start = false;
    protected SaveData store = null;
    private static final int WritePermission = 0x11;
    private static String[] Permissions={
            Manifest.permission.WRITE_EXTERNAL_STORAGE
    };

    private SaveToFile saveService;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        boolean granted = true; // This is never used!
        //setupStartButton();
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


    /*private void setupStartButton (){
        // Get reference to button
        //super.onStart();
        Button startButton = (Button)findViewById(R.id.startColl);

        // Set click listen
        startButton.setOnClickListener(
                new Button.OnClickListener() {
                    public void onClick(View v){
                        /*Intent intent = new Intent(this, SaveToFile.class);
                        startService(intent);
                    }
                }
        );
    }*/
    protected void onStart() {
        super.onStart();
        // bind to Service
        Intent intent = new Intent(this, SaveToFile.class);
        bindService(intent, serviceConnection, Context.BIND_AUTO_CREATE);
    }
    private ServiceConnection serviceConnection = new ServiceConnection() {

        @Override
        public void onServiceConnected(ComponentName className, IBinder service) {
            // cast the IBinder and get MyService instance
            LocalBinder binder = (LocalBinder) service;
            myService = binder.getService();
            bound = true;
            saveService.setCallbacks(MainActivity.this); // register
        }

        @Override
        public void onServiceDisconnected(ComponentName arg0) {
            bound = false;
        }
    };

}
