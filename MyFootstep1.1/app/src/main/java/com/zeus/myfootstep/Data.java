package com.zeus.myfootstep;

/**
 * Created by ziqisu on 9/20/16.
 */

public class Data {
    protected static String label;
    protected static float[] values;
    protected static long time;

    public Data(long time, float[] values, String label){
        this.time=time;
        this.values=values;
        this.label = label;
    }
    public Data(){

    }
}
