static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake) => (knightIsAwake) ? false : true; 
    
//        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFastAttack() method");


    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake) => (knightIsAwake || archerIsAwake || prisonerIsAwake) ? true : false;
    
//        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSpy() method");
    

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
=> (!archerIsAwake && prisonerIsAwake) ? true : false;
//        throw new NotImplementedException("Please implement the (static) QuestLogic.CanSignalPrisoner() method");
    

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent) => (petDogIsPresent && !archerIsAwake) || (!petDogIsPresent && prisonerIsAwake && !knightIsAwake && !archerIsAwake) ? true : false;
    
//        throw new NotImplementedException("Please implement the (static) QuestLogic.CanFreePrisoner() method");
    
}
