using Zinc;

Engine.Run(new Engine.RunOptions(1920,1080,"zinc", () => {
        new Shape(new Color(Palettes.ENDESGA[9]))
        {
            X = Engine.Width / 2f,
            Y = Engine.Height / 2f,
        };
    }
));