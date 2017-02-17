<?php
$x=readline("Input no.of elements:");
for($i=0;$i<$x;$i++)
{
	$y[$i]=readline(($i+1).": ");
}
echo "Original Array:";
for($i=0;$i<$x;$i++)
{
	echo $y[$i];
}
echo "\n";
$j=0;
echo "Reversed Array:";
for($i=$x-1;$i>=0;$i--)
{
		$z[$j]=$y[$i];
		$j++;
}
for($i=0;$i<$x;$i++)
{
	echo $z[$i];
}

?>
