using lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace lab3.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    static readonly QuizModel quiz = new QuizModel();

    public IActionResult Quiz()
    {
        quiz.SetRandomValues();
        ViewBag.Question = quiz.Question;
        return View();
    }

    public IActionResult QuizResult()
    {
        ViewBag.RightAnswersCount = quiz.RightAnswersCount;
        ViewBag.AnswersCount = quiz.AnswersCount;
        ViewBag.Results = quiz.Results;
        return View();
    }

    [HttpPost]
    public IActionResult QuizNext(int answer)
    {
        quiz.UppdateResults(answer);
        quiz.SetRandomValues();
        ViewBag.Question = quiz.Question;
        return View("Quiz");
    }

    public IActionResult QuizFinish(int answer)
    {
        quiz.UppdateResults(answer);
        ViewBag.RightAnswersCount = quiz.RightAnswersCount;
        ViewBag.AnswersCount = quiz.AnswersCount;
        ViewBag.Results = quiz.Results;
        return View("QuizResult");
    }
}