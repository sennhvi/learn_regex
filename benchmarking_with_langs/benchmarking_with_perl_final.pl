use Time::HiRes 'time';             # make the return value of time() accurate
$TimesToDo = 1000;                  # set repetitions
$TestString = "abababdedfg" x 1000; # generate long string

$Count = $TimesToDo;
$StartTime = time();
while ($Count-- > 0) {
    # body...
    $TestString =~ m/^(a|b|c|d|e|f|g)+$/;
}
$EndTime = time();
printf("Alternation takes %.3f seconds.\n", $EndTime - $StartTime);

$Count = $TimesToDo;
$StartTime = time();
while ($Count-- > 0) {
    # body...
    $TestString =~ m/^[a-g]+$/;
}
"abababdedfg" =~ m/^[a-g]+$/;
$EndTime = time();
printf("Character class takes %.3f seconds.\n", $EndTime - $StartTime);
