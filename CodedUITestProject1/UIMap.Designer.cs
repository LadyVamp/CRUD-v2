﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Этот код был создан построителем кодированных тестов ИП.
//      Версия: 11.0.0.0
//
//      Изменения, внесенные в этот файл, могут привести к неправильной работе кода и будут
//      утрачены при повторном формировании кода.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject1
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Построитель кодированных тестов ИП", "11.0.50727.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// EnterKeyword_KeywordIsFind - Используйте "EnterKeyword_KeywordIsFindParams" для передачи параметров в этот метод.
        /// </summary>
        public void EnterKeyword_KeywordIsFind()
        {
            #region Variable Declarations
            WinEdit uITxtKeywordsEdit = this.UIForm1Window.UITxtKeywordsWindow.UITxtKeywordsEdit;
            WinButton uIПоискпоключевымсловаButton = this.UIForm1Window.UIПоискпоключевымсловаWindow.UIПоискпоключевымсловаButton;
            #endregion

            // Тип "git" в "txtKeywords" надпись
            uITxtKeywordsEdit.Text = this.EnterKeyword_KeywordIsFindParams.UITxtKeywordsEditText;

            // Щелкните "Поиск по ключевым словам" кнопка
            Mouse.Click(uIПоискпоключевымсловаButton, new Point(31, 10));
        }
        
        /// <summary>
        /// EnterKeyword_KeywordIsNotFind - Используйте "EnterKeyword_KeywordIsNotFindParams" для передачи параметров в этот метод.
        /// </summary>
        public void EnterKeyword_KeywordIsNotFind()
        {
            #region Variable Declarations
            WinEdit uITxtKeywordsEdit = this.UIForm1Window.UITxtKeywordsWindow.UITxtKeywordsEdit;
            WinButton uIПоискпоключевымсловаButton = this.UIForm1Window.UIПоискпоключевымсловаWindow.UIПоискпоключевымсловаButton;
            WinButton uIОКButton = this.UIОКWindow.UIОКButton;
            #endregion

            // Тип "git" в "txtKeywords" надпись
            uITxtKeywordsEdit.Text = this.EnterKeyword_KeywordIsNotFindParams.UITxtKeywordsEditText;

            // Щелкните "Поиск по ключевым словам" кнопка
            Mouse.Click(uIПоискпоключевымсловаButton, new Point(31, 10));

            // Тип "qqq" в "txtKeywords" надпись
            uITxtKeywordsEdit.Text = this.EnterKeyword_KeywordIsNotFindParams.UITxtKeywordsEditText1;

            // Щелкните "Поиск по ключевым словам" кнопка
            Mouse.Click(uIПоискпоключевымсловаButton, new Point(61, 12));

            // Щелкните "ОК" кнопка
            Mouse.Click(uIОКButton, new Point(59, 13));
        }
        
        #region Properties
        public virtual EnterKeyword_KeywordIsFindParams EnterKeyword_KeywordIsFindParams
        {
            get
            {
                if ((this.mEnterKeyword_KeywordIsFindParams == null))
                {
                    this.mEnterKeyword_KeywordIsFindParams = new EnterKeyword_KeywordIsFindParams();
                }
                return this.mEnterKeyword_KeywordIsFindParams;
            }
        }
        
        public virtual EnterKeyword_KeywordIsNotFindParams EnterKeyword_KeywordIsNotFindParams
        {
            get
            {
                if ((this.mEnterKeyword_KeywordIsNotFindParams == null))
                {
                    this.mEnterKeyword_KeywordIsNotFindParams = new EnterKeyword_KeywordIsNotFindParams();
                }
                return this.mEnterKeyword_KeywordIsNotFindParams;
            }
        }
        
        public UIForm1Window UIForm1Window
        {
            get
            {
                if ((this.mUIForm1Window == null))
                {
                    this.mUIForm1Window = new UIForm1Window();
                }
                return this.mUIForm1Window;
            }
        }
        
        public UIОКWindow UIОКWindow
        {
            get
            {
                if ((this.mUIОКWindow == null))
                {
                    this.mUIОКWindow = new UIОКWindow();
                }
                return this.mUIОКWindow;
            }
        }
        #endregion
        
        #region Fields
        private EnterKeyword_KeywordIsFindParams mEnterKeyword_KeywordIsFindParams;
        
        private EnterKeyword_KeywordIsNotFindParams mEnterKeyword_KeywordIsNotFindParams;
        
        private UIForm1Window mUIForm1Window;
        
        private UIОКWindow mUIОКWindow;
        #endregion
    }
    
    /// <summary>
    /// Параметры для передачи в "EnterKeyword_KeywordIsFind"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "11.0.50727.1")]
    public class EnterKeyword_KeywordIsFindParams
    {
        
        #region Fields
        /// <summary>
        /// Тип "git" в "txtKeywords" надпись
        /// </summary>
        public string UITxtKeywordsEditText = "git";
        #endregion
    }
    
    /// <summary>
    /// Параметры для передачи в "EnterKeyword_KeywordIsNotFind"
    /// </summary>
    [GeneratedCode("Построитель кодированных тестов ИП", "11.0.50727.1")]
    public class EnterKeyword_KeywordIsNotFindParams
    {
        
        #region Fields
        /// <summary>
        /// Тип "git" в "txtKeywords" надпись
        /// </summary>
        public string UITxtKeywordsEditText = "git";
        
        /// <summary>
        /// Тип "qqq" в "txtKeywords" надпись
        /// </summary>
        public string UITxtKeywordsEditText1 = "qqq";
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "11.0.50727.1")]
    public class UIForm1Window : WinWindow
    {
        
        public UIForm1Window()
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Form1";
            this.SearchProperties.Add(new PropertyExpression(WinWindow.PropertyNames.ClassName, "WindowsForms10.Window", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public UITxtKeywordsWindow UITxtKeywordsWindow
        {
            get
            {
                if ((this.mUITxtKeywordsWindow == null))
                {
                    this.mUITxtKeywordsWindow = new UITxtKeywordsWindow(this);
                }
                return this.mUITxtKeywordsWindow;
            }
        }
        
        public UIПоискпоключевымсловаWindow UIПоискпоключевымсловаWindow
        {
            get
            {
                if ((this.mUIПоискпоключевымсловаWindow == null))
                {
                    this.mUIПоискпоключевымсловаWindow = new UIПоискпоключевымсловаWindow(this);
                }
                return this.mUIПоискпоключевымсловаWindow;
            }
        }
        #endregion
        
        #region Fields
        private UITxtKeywordsWindow mUITxtKeywordsWindow;
        
        private UIПоискпоключевымсловаWindow mUIПоискпоключевымсловаWindow;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "11.0.50727.1")]
    public class UITxtKeywordsWindow : WinWindow
    {
        
        public UITxtKeywordsWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "txtKeywords";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinEdit UITxtKeywordsEdit
        {
            get
            {
                if ((this.mUITxtKeywordsEdit == null))
                {
                    this.mUITxtKeywordsEdit = new WinEdit(this);
                    #region Условия поиска
                    this.mUITxtKeywordsEdit.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUITxtKeywordsEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUITxtKeywordsEdit;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "11.0.50727.1")]
    public class UIПоискпоключевымсловаWindow : WinWindow
    {
        
        public UIПоискпоключевымсловаWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlName] = "btnSearchKeywords";
            this.WindowTitles.Add("Form1");
            #endregion
        }
        
        #region Properties
        public WinButton UIПоискпоключевымсловаButton
        {
            get
            {
                if ((this.mUIПоискпоключевымсловаButton == null))
                {
                    this.mUIПоискпоключевымсловаButton = new WinButton(this);
                    #region Условия поиска
                    this.mUIПоискпоключевымсловаButton.SearchProperties[WinButton.PropertyNames.Name] = "Поиск по ключевым словам";
                    this.mUIПоискпоключевымсловаButton.WindowTitles.Add("Form1");
                    #endregion
                }
                return this.mUIПоискпоключевымсловаButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIПоискпоключевымсловаButton;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "11.0.50727.1")]
    public class UIОКWindow : WinWindow
    {
        
        public UIОКWindow()
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.Name] = "ОК";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Button";
            this.WindowTitles.Add("ОК");
            #endregion
        }
        
        #region Properties
        public WinButton UIОКButton
        {
            get
            {
                if ((this.mUIОКButton == null))
                {
                    this.mUIОКButton = new WinButton(this);
                    #region Условия поиска
                    this.mUIОКButton.SearchProperties[WinButton.PropertyNames.Name] = "ОК";
                    this.mUIОКButton.WindowTitles.Add("ОК");
                    #endregion
                }
                return this.mUIОКButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIОКButton;
        #endregion
    }
}