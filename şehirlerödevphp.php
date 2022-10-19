<?php 

$sehirler = array("kütahya","eskisehir","ankara");

$i = 0;  

while ($i < count($sehirler)) {

   $a = $sehirler[$i];
   
   echo $a ."\n";
   
   $i++;
}
$sehirler = array( "kütahya","eskisehir","ankara");

for($i = 0; $i < count($sehirler); $i++){

echo $sehirler[$i]."\n";
$sehirler = array("kütahya","eskisehir","ankara");
$i = 0;
do {
	  
	   $a = $sehirler[$i];
   $i++;
   echo $a ."\n";     
}
while ($i < count($sehirler))
$sehirler= array("kütahya","eskisehir","ankara");
 
foreach( $sehirler as $s ) {

   echo $s.'<br>';
}
 
?>