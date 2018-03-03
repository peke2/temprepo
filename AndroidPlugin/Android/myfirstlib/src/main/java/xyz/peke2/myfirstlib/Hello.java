package xyz.peke2.myfirstlibrary;

import xyz.peke2.myfirstlib.HelloParam;

/**
 * Created by peke2 on 2018/02/28.
 */

public class Hello {
    public Hello()
    {
    }

    public static String say()
    {
        return "hello";
    }

    public static int add(int a, int b)
    {
        return a + b;
    }

    public static int sum(HelloParam param)
    {
        int len = param.values.length;
        int total = 0;
        for(int i=0; i<len; i++)
        {
            total += param.values[i];
        }
        return total;
    }
}
