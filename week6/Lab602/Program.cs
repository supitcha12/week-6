using System;
using System.Collections.Generic;
 
namespace Lab6
{
  class MainApp
  {
    static void Main()
    {
      Document[] documents = new Document[2];
 
      documents[0] = new Resume();
      documents[1] = new Report();
 
      // Display document pages
      foreach (Document document in documents)
      {
        Console.WriteLine("\n" + document.GetType().Name + "--");
        foreach (Page page in document.Pages)
        {
          Console.WriteLine(" " + page.GetType().Name);
        }
      }
 
      // Wait for user
      Console.ReadKey();
    }
  }
 
  abstract class Page
  {
  }
 
  class SkillsPage : Page
  {
  }
 
  class EducationPage : Page
  {
  }
 
  class ExperiencePage : Page
  {
  }
 
  class IntroductionPage : Page
  {
  }
 
  class ResultsPage : Page
  {
  }
 
  class ConclusionPage : Page
  {
  }
 
  class SummaryPage : Page
  {
  }
 
  class BibliographyPage : Page
  {
  }
 
  abstract class Document
  {
    private List<Page> _pages = new List<Page>();
 
    public Document()
    {
      this.CreatePages();
    }
 
    public List<Page> Pages
    {
      get { return _pages; }
    }
 
    public abstract void CreatePages();
  }
 
  class Resume : Document
  {
    public override void CreatePages()
    {
      Pages.Add(new SkillsPage());
      Pages.Add(new EducationPage());
      Pages.Add(new ExperiencePage());
    }
  }
 
  class Report : Document
  {
    public override void CreatePages()
    {
      Pages.Add(new IntroductionPage());
      Pages.Add(new ResultsPage());
      Pages.Add(new ConclusionPage());
      Pages.Add(new SummaryPage());
      Pages.Add(new BibliographyPage());
    }
  }
}


