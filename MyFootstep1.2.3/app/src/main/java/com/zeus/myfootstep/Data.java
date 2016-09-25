package com.zeus.myfootstep;

/**
 * Created by Zeus on 9/22/2016.
 */
public class Data {
    protected String label;
    protected float[] values;
    protected long time;


    public Data(String label, float[] value, long time){
        this.time= time;
        this.values = value;
        this.label = label;
    }
}
