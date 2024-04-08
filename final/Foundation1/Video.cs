 using System;
 using System.Collections.Generic;
 
  class  Video
{
    protected string _title;
    protected string _author;
    protected int _length;
    protected List<Comment> comments;

    

    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
        comments = new List<Comment>();
    }

    public string Title()
    {
        return this._title;
    }
    public string Author()
    {
        return this._author;
    }
    public int Length()
    {
        return this._length;
    }
     public List<Comment> GetComments()
    {
        return this.comments;
    }
    public void  AddComment(string userName, string text)
    {
        comments.Add(new Comment(userName, text));
    }

    public int NumberOfComments()
    {
        return comments.Count;
    }
}