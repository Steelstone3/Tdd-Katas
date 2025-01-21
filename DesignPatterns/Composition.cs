public interface IPublish {
    public void Publish();
}

public interface IComments {
    public void Comments();
}

public class NewsArticle : IPublish
{
    public void Publish()
    {
        throw new System.NotImplementedException();
    }
}

public class InternetArticle : IPublish, IComments
{
    public void Comments()
    {
        throw new System.NotImplementedException();
    }

    public void Publish()
    {
        throw new System.NotImplementedException();
    }
}

public class Blog : IPublish, IComments
{
    public void Comments()
    {
        throw new System.NotImplementedException();
    }

    public void Publish()
    {
        throw new System.NotImplementedException();
    }
}