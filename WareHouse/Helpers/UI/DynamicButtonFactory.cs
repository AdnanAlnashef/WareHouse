using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.Drawing;

namespace WareHouse.Helpers.UI
{
    public static class DynamicButtonFactory
    {
        public static void CreateButtonsWithOverFlow<T>(FlowLayoutPanel panel, List<T> items,
            Func<T, string> textSelector, EventHandler onItemClick, int maxVisibleButtons)
        {
            panel.Controls.Clear();
            int index = 0;
            ShowPage();

            void ShowPage()
            {
                panel.Controls.Clear();

                if (index > 0)
                {
                    var prevBtn = new Guna2Button
                    {
                        Text = "<==",
                        Width = 80,
                        Height = 40,
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        FillColor = Color.White,
                        ForeColor = Color.Navy,
                        BorderRadius = 12,
                        Cursor = Cursors.Hand,
                        Animated = true
                    };
                    prevBtn.Click += (s, e) =>
                    {
                        index -= maxVisibleButtons;
                        ShowPage();
                    };
                    panel.Controls.Add(prevBtn);
                }

                var PageItems = items.Skip(index).Take(maxVisibleButtons).ToList();
                foreach ( var item in PageItems )
                {
                    var btn = CreateButton(textSelector(item), item, onItemClick);
                    panel.Controls.Add(btn);
                }
                if (index + maxVisibleButtons < items.Count)
                {
                    panel.Controls.Add(CreateMoreButton());
                }
            }

           Guna2Button CreateMoreButton()
            {
                var moreBtn = new Guna2Button
                {
                    Text = "==>",
                    Width = 80,
                    Height = 40,
                    Font = new Font("Segoe UI", 14, FontStyle.Bold),
                    FillColor = Color.White,
                    ForeColor = Color.Navy,
                    BorderRadius = 12,
                    Cursor = Cursors.Hand,
                    Animated = true
                };
                moreBtn.Click += (s, e) =>
                {
                    index += maxVisibleButtons;
                    ShowPage();
                };
                return moreBtn;
            }
        }

        private static Guna2Button CreateButton<T>(string text, T item, EventHandler onClick)
        {
            var btn = new Guna2Button
            {
                Text = text,
                Size = new Size(105, 64),
                Font = new Font("segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Navy,
                FillColor = Color.White,
                BorderRadius = 12,
                Cursor = Cursors.Hand,
                Animated = true,
                Tag = item
            };
            btn.Click += onClick;
            return btn;
        }
    }
}
