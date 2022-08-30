public class PlayerData
{
	private static short NumOfScenes = SceneLoader.NUM_OF_SCENES;
	public static bool[] SceneCompleted = new bool[NumOfScenes];
	public static short NumOfTipsS1, NumOfTipsS2;
	public static int[] NumOfKboardInputs = new int[NumOfScenes];
	public static int[] NumOfQuits = new int[NumOfScenes];
	public static int[] NumOfClicks = new int[NumOfScenes];
	public static double[] PlayerResponseTime = new double[NumOfScenes];
	public static bool ResponseTimedS2;
	public static double[] PlayDurationPerScene = new double[NumOfScenes];

	private static void ResetCommonSceneData(short scenceIdx)
	{
		NumOfKboardInputs[scenceIdx] = 0;
		NumOfClicks[scenceIdx] = 0;
		PlayerResponseTime[scenceIdx] = 0;
		PlayDurationPerScene[scenceIdx] = 0;
	}

	public static void ResetScene1Data()
	{
		NumOfTipsS1 = 0;
		ResetCommonSceneData(0);
	}

	public static void ResetScene2Data()
	{
		NumOfTipsS2 = 0;
		ResponseTimedS2 = false;
		ResetCommonSceneData(1);
	}

	public static void ResetScene3Data()
	{
		ResetCommonSceneData(2);
	}

	private static void ResetGameData()
	{
		for (int i = 0; i < NumOfScenes; i++)
		{
			SceneCompleted[i] = false;
			NumOfQuits[i] = 0;
		}
	}
}