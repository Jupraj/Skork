﻿using System.Drawing;

namespace Skork.keywords {
    class SkorkRight {

        public void right(SkorkSprite s, int x = 1) {
            if (s.Location.X + 1 < 0 && x > 0) {
                s.Location = new Point(s.Location.X + 1, s.Location.Y);
                System.Windows.Forms.MessageBox.Show("RIGHT " + x);
                right(s, --x);
            } else { return; }
        }
    }
}
