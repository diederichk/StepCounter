package com.zeus.myfootstep;

import android.app.Service;
import android.content.Intent;
import android.os.IBinder;
import android.widget.Toast;

public class SaveToFile extends Service {
    public SaveToFile() {
    }
    @Override
    public void onCreate() {
       // Needs to be fixed
    }

    @Override
    public int onStartCommand(Intent intent, int flags, int startId) {
        // Needs to be fixed
        return 1;
    }

    @Override
    public IBinder onBind(Intent intent) {
        // We don't provide binding, so return null
        return null;
    }

    @Override
    public void onDestroy() {
        Toast.makeText(this, "service done", Toast.LENGTH_SHORT).show();
    }
}
