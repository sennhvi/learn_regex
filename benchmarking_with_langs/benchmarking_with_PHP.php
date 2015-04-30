$TimeToDO = 1000;

/* prepare testing string */
$TestString = "";
for ($i = 0; $i < 1000; $i++)
    $TestString .= "abababdedfg";

/* start first test */
$start = gettimeofday()
for ($i = 0; $i < $TimeToDO; $i++)
    preg_match('/^(a|b|c|d|e|f|g)+$/', $TestString);
$final = gettimeofday()
$sec = ($final['sec'] + $final['usec']/1000000)-
    ($start['sec'] + $start['usec']/1000000);
printf("Alternation takes %.3f seconds\n", $sec);

/* start second test */
$start = gettimeofday()
for ($i = 0; $i < $TimeToDO; $i++)
    preg_match('/^[a-g]+$/', $TestString);
$final = gettimeofday()
$sec = ($final['sec'] + $final['usec']/1000000)-
    ($start['sec'] + $start['usec']/1000000);
printf("Character class takes %.3f seconds\n", $sec);
