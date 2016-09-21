package com.zeus.myfootstep;

import android.os.Environment;
import android.util.Log;

import java.io.DataOutputStream;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;

/**
 * Created by ziqisu on 9/20/16.
 */

public class SaveData extends Thread {
    public void run(){
        String state;
        state = Environment.getExternalStorageState();

        if(Environment.MEDIA_MOUNTED.equals(state)){
            File Root = Environment.getExternalStorageDirectory();
            //File Dir = new File(Root.getAbsolutePath()+"/A+G Data");
            File Dir = new File("/sdcard"+"/AG Data");
            if(! Dir.exists()){
                Dir.mkdir();
                Log.i("make a dir","/n");


            }
            Log.i("already make a dir","/n");
            Log.i("file location is:",Dir.toString());

            DateFormat df = new SimpleDateFormat("dd MM yyyy, HH:mm");
            String date = df.format(Calendar.getInstance().getTime());
            date = date+".txt";
            File file = new File(Dir, date);
            try{
                DataOutputStream steam = new DataOutputStream(new FileOutputStream(file));
                StringBuilder sb = new StringBuilder();
                while(MainActivity.start == true ){
                    sb.setLength(0);
                    Data data = MainActivity.queue.take();
                    sb.append(data.time);
                    sb.append(",");
                    sb.append(data.label);
                    sb.append(",");
                    sb.append(data.values[0]);
                    sb.append(",");
                    sb.append(data.values[1]);
                    sb.append(",");
                    sb.append(data.values[2]);
                    sb.append("\n");
                    steam.writeBytes(sb.toString());

                }
                steam.close();

            }catch(FileNotFoundException e){
                e.printStackTrace();
            }catch(InterruptedException e){
                e.printStackTrace();
            }catch (IOException e){
                e.printStackTrace();
            }


        }
    }
}
