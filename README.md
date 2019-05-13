# CSHP220B_Class5_Homework
Class 5 Homework - Catherine Powell

Homework 5: Tic-Tac-Toe

The object is to get three in a row.

Rules:

Allow placement only on empty spots.
X goes first, then O
When you get three in a row, you declare a winner.

When a winner is declared, you disable any further development.

The menu has File | New Game and File | Exit.

New Game will erase the board and start with X again.

The solution will be posted on Github after the class ends.

You must use the following unmodified MainWindow.xaml.

MainWindow.xaml
<DockPanel>
    <Menu DockPanel.Dock="Top">
        <MenuItem Header="_File">
            <MenuItem x:Name="uxNewGame" Header="_New Game" Click="uxNewGame_Click"></MenuItem>
            <MenuItem Header="E_xit" Click="uxExit_Click"></MenuItem>
        </MenuItem>
    </Menu>

    <StatusBar Height="24" DockPanel.Dock="Bottom">
        <StatusBarItem>
            <TextBlock x:Name="uxTurn"></TextBlock>
        </StatusBarItem>
    </StatusBar>

    <Border BorderBrush="Black" BorderThickness="2">
        <Grid x:Name="uxGrid" Background="pink">
            <Grid.RowDefinitions>
                <RowDefinition Height="50"></RowDefinition>
                <RowDefinition Height="50"></RowDefinition>
                <RowDefinition Height="50"></RowDefinition>
            </Grid.RowDefinitions>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="50"></ColumnDefinition>
                <ColumnDefinition Width="50"></ColumnDefinition>
                <ColumnDefinition Width="50"></ColumnDefinition>
            </Grid.ColumnDefinitions>

            <Button Grid.Row="0" Grid.Column="0" Click="Button_Click" Tag="0,0"></Button>
            <Button Grid.Row="0" Grid.Column="1" Click="Button_Click" Tag="0,1"></Button>
            <Button Grid.Row="0" Grid.Column="2" Click="Button_Click" Tag="0,2"></Button>
            <Button Grid.Row="1" Grid.Column="0" Click="Button_Click" Tag="1,0"></Button>
            <Button Grid.Row="1" Grid.Column="1" Click="Button_Click" Tag="1,1"></Button>
            <Button Grid.Row="1" Grid.Column="2" Click="Button_Click" Tag="1,2"></Button>
            <Button Grid.Row="2" Grid.Column="0" Click="Button_Click" Tag="2,0"></Button>
            <Button Grid.Row="2" Grid.Column="1" Click="Button_Click" Tag="2,1"></Button>
            <Button Grid.Row="2" Grid.Column="2" Click="Button_Click" Tag="2,2"></Button>
        </Grid>
    </Border>
</DockPanel>
HINT: Notice the Tag and that you ONLY have the Button_Click event. The tag gives you the row and column. The tag is also an object but as you can see it is actually a string (unbox it or call ToString). Then you can parse the string into row and column. 

Remember the Button_Click event has an object sender parameter. That sender object is a Button, so cast it to a Button and get the Tag object.
