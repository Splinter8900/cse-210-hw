public class ScriptureCollection {
    private List<Scripture> _scriptures;

    public ScriptureCollection() {
        _scriptures = new List<Scripture>();
        
        _scriptures.Add(new Scripture(new Reference("D+C", 90, 24),
                                       "Search diligently, pray always, and be believing, and all things shall work together for your good."));
        _scriptures.Add(new Scripture(new Reference("John", 3, 16),
                                       "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."));
        _scriptures.Add(new Scripture(new Reference("1 Nephi", 3, 7),
                                       "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."));
        _scriptures.Add(new Scripture(new Reference("Matthew", 6, 33),
                                       "But seek ye first the kingdom of God, and his righteousness; and all these things shall be added unto you."));
        _scriptures.Add(new Scripture(new Reference("2 Timothy", 1, 7),
                                       "For God hath not given us the spirit of fear; but of power, and of love, and of a sound mind."));
    }

    public Scripture GetRandomScripture() {
        Random random = new Random();
        return _scriptures[random.Next(_scriptures.Count)];
    }
}