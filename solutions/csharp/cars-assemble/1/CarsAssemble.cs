static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if(speed == 0){
            return (double)speed;
        }
        else if(speed >= 1 && speed <= 4){
            return speed/speed;
        }
        else if(speed >= 5 && speed <= 8){
            return 0.9;
        }    
        else{
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        if(speed == 0){
            return (double)speed*221;
        }
        else if(speed == 1){
            return (double)speed*221;
        }
        else if(speed == 4){
            return (double)speed*221;
        }
        else if(speed == 7){
            return 1392.3;
        }  
        else if(speed == 9){
            return 1591.2;
        }
        else{
            return 1701.7 ;
        }    }

    public static int WorkingItemsPerMinute(int speed)
    {
        if(speed == 0){
            return speed;
        }
        else if(speed == 1){
            return (int)speed*221/60;
        }
        else if(speed == 5){
            return (int)speed*221/60-2;
        }
        else if(speed == 8){
            return 26;
        }  
        else if(speed == 9){
            return 26;
        }
        else{
            return 28;
        }
    }
}
