﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SummerOutreach.ComponentHelper;

namespace SummerOutreach.ExtensionClass
{
    public static class JavaScriptExtensionClass
    {
        public static void ScrollToElementAndClick(this IWebElement element)
        {
            Thread.Sleep(100);
            JavaScriptExecutorHelper.ScrollElementAndClick(element);
        }

        public static void ScrollToElementAndType(this IWebElement element,string text)
        {
            Thread.Sleep(100);
            JavaScriptExecutorHelper.ScrollElementAndClick(element);
            element.SendKeys(text);
        }
    }
}
