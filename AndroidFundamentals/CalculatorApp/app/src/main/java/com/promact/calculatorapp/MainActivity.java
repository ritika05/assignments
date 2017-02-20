package com.promact.calculatorapp;

import android.content.DialogInterface;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {
    private Button btn_0,btn_2,btn_3,btn_4,btn_5,btn_6,btn_7,btn_8,btn_9,btn_1,btn_add,btn_sub,btn_clear,btn_equal;
    private TextView result,display;
    private int val1=0,val2,sum=0;
    private boolean add,sub,divide,mul;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        btn_0= (Button) findViewById(R.id.Zero);
        btn_1= (Button) findViewById(R.id.One);
        btn_2= (Button) findViewById(R.id.Two);
        btn_3= (Button) findViewById(R.id.Three);
        btn_4= (Button) findViewById(R.id.Four);
        btn_5= (Button) findViewById(R.id.Five);
        btn_6= (Button) findViewById(R.id.Six);
        btn_7= (Button) findViewById(R.id.Seven);
        btn_8= (Button) findViewById(R.id.Eight);
        btn_9= (Button) findViewById(R.id.Nine);
        btn_add= (Button) findViewById(R.id.Add);
        btn_sub= (Button) findViewById(R.id.Sub);
        btn_equal= (Button) findViewById(R.id.Equal);
        btn_clear= (Button) findViewById(R.id.Clear);
        result= (TextView) findViewById(R.id.TextInput);
        display= (TextView) findViewById(R.id.TextResult);

        btn_0.setOnClickListener(this);
        btn_1.setOnClickListener(this);
        btn_2.setOnClickListener(this);
        btn_3.setOnClickListener(this);
        btn_4.setOnClickListener(this);
        btn_5.setOnClickListener(this);
        btn_6.setOnClickListener(this);
        btn_7.setOnClickListener(this);
        btn_8.setOnClickListener(this);
        btn_9.setOnClickListener(this);
        btn_add.setOnClickListener(this);
        btn_sub.setOnClickListener(this);
        btn_clear.setOnClickListener(this);
        btn_equal.setOnClickListener(this);



    }

    @Override
    public void onClick(View v) {


        switch (v.getId()) {

            case R.id.Zero:
                val1=val1*10+Integer.parseInt(btn_0.getText().toString());
                display.append(btn_0.getText());

                break;
            case R.id.One:
                val1=val1*10+Integer.parseInt(btn_1.getText().toString());
                display.append(btn_1.getText());

                break;
            case R.id.Two:
                val1=val1*10+Integer.parseInt(btn_2.getText().toString());
                display.append(btn_2.getText());

                break;
            case R.id.Three:
                val1=val1*10+Integer.parseInt(btn_3.getText().toString());
                display.append(btn_3.getText());

                break;
            case R.id.Four:
                val1=val1*10+Integer.parseInt(btn_4.getText().toString());
                display.append(btn_4.getText());

                break;
            case R.id.Five:
                val1=val1*10+Integer.parseInt(btn_5.getText().toString());
                display.append(btn_5.getText());

                break;
            case R.id.Six:
                val1=val1*10+Integer.parseInt(btn_6.getText().toString());
                display.append(btn_6.getText());

                break;
            case R.id.Seven:
                val1=val1*10+Integer.parseInt(btn_7.getText().toString());
                display.append(btn_7.getText());

                break;
            case R.id.Eight:
                val1=val1*10+Integer.parseInt(btn_8.getText().toString());
                display.append(btn_8.getText());

                break;
            case R.id.Nine:
                val1=val1*10+Integer.parseInt(btn_9.getText().toString());
                display.append(btn_9.getText());

                break;

            case R.id.Add:
                if(display.getText().equals(0))
                    display.setText("");
                display.append(btn_add.getText());
                sum=sum+val1;
                val1=0;

                add=true;
                break;
            case R.id.Clear:
                display.setText("");
                result.setText("");
                sum=0;

                break;

            case R.id.Sub:
                if(display.getText().equals(0))
                    display.setText("");
                display.append(btn_sub.getText());
                if(val1 >sum)
                    sum=val1-sum;
                if(sum >val1)
                    sum=sum-val1;
                val1=0;
                sub=true;
                break;
            case R.id.Equal:
                if(val1!=0) {

                    if (add == true) {
                        sum = sum + val1;
                        add = false;
                    }


                    if (sub == true) {
                        sum = sum - val1;
                        sub = false;
                    }

                }
                result.setText(""+sum);
                val1=0;
                break;

        }

    }
}
