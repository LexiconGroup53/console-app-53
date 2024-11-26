namespace console_app;

public class Hyphenation
{
    private static string originalText =
        "Nick sat against the wall of the church where they had dragged him to be clear of machine gun fire in the street. Both legs stuck out awkwardly. He had been hit in the spine. His face was sweaty and dirty. The sun shone on his face. The day was very hot. Rinaldi, big backed, his equipment sprawling, lay face downward against the wall. Nick looked straight ahead brilliantly. The pink wall of the house opposite had fallen out from the roof, and an iron bedstead hung twisted toward the street. Two Austrian dead lay in the rubble in the shade of the house. Up the street were other dead. Things were getting forward in the town. It was going well. Stretcher bearers would be along any time now. Nick turned his head carefully and looked down at Rinaldi. Senta Rinaldi. Senta. You and me we’ve made a separate peace. Rinaldi lay still in the sun breathing with difficulty. Not patriots. Nick turned his head carefully away smiling sweatily. Rinaldi was a disappointing audience. While the bombardment was knocking the trench to pieces at Fossalta, he lay very flat and sweated and prayed oh jesus christ get me out of here. Dear jesus please get me out. Christ please please please christ. If you’ll only keep me from getting killed I’ll do anything you say. I believe in you and I’ll tell everyone in the world that you are the only thing that matters. Please please dear jesus. The shelling moved further up the line. We went to work on the trench and in the morning the sun came up and the day was hot and muggy and cheerful and quiet. The next night back at Mestre he did not tell the girl he went upstairs with at the Villa Rossa about Jesus. And he never told anybody.";

    public static string[] GetFormattedText()
    {
        string workingText = originalText.Substring(0);
        bool isTextLeft = true;
        string manipulatedText = "";
        while (isTextLeft)
        {
            string line = GetLine(workingText);
            manipulatedText = manipulatedText + line + "!%€";
            workingText = workingText.Remove(0, line.Trim('-').Length).Trim();
            if (workingText.Equals("")) isTextLeft = false;
        }

        return manipulatedText.Split("!%€", StringSplitOptions.RemoveEmptyEntries);
    }

    private static string GetLine(string text)
    {
        bool hyphenate = false;
        int lineLength = 50;
        if (text.Length < 51) lineLength = text.Length;
        else if (text[48] == ' ') lineLength = 49;
        else if (text[51] == ' ') lineLength = 51;
        else if (!text.Substring(48, 4).Contains(' ')) hyphenate = true;
        return text.Substring(0, lineLength) + (hyphenate ? "-" : "");
    }
}