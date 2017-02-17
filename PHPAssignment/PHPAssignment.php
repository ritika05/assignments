<?php

$x=readline("Input no.of rows:");
	$k=1;
	$y=($x+1)/2;
	$z=$y;
for($i=0;$i<$z;$i++)
{
		for ($j=$y-1;$j>0;$j--)
	{
		echo " ";	
	}


	for($j=1;$j<=$i+$k;$j++)
	{
		echo "*";
	}
	echo "\n";
	if($k==($x+1)/2)
		break;
	else
		$k++;
	$y--;
}
	$y=($x+1)/2;
for($i=1;$i<=$z;$i++)
{
	for($j=1;$j<=$i;$j++)
	{
		echo " ";
	}
	for($j=$y-1;$j>0;$j--)
	{
		echo "*";
	}
	for($j=$y-2;$j>0;$j--)
	{
		echo "*";
	}
	echo "\n";
	$y--;
	

}
?>