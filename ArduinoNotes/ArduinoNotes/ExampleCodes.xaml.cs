using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TextCopy;

namespace ArduinoNotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExampleCodes : ContentPage
    {
        public ExampleCodes()
        {
            InitializeComponent();

            //

            BlinkHeader.Text = blinkHeader;
            BlinkCode.Text = blinkCode;
            Blink.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    HomePage noteCurrentPage = new HomePage();
                    ScrollView noteCurrentPageView = new ScrollView();
                    StackLayout noteCurrentPageLayout = new StackLayout();
                    noteCurrentPageLayout.BackgroundColor = Color.Black;

                    Label headerLabelForCurrentPage = new Label();
                    headerLabelForCurrentPage.Text = blinkHeader;
                    headerLabelForCurrentPage.TextColor = Color.White;
                    headerLabelForCurrentPage.HorizontalTextAlignment = TextAlignment.Center;
                    headerLabelForCurrentPage.FontSize = 26;
                    headerLabelForCurrentPage.WidthRequest = 400;
                    headerLabelForCurrentPage.HeightRequest = 100;

                    Label noteLabelForCurrentPage = new Label();
                    noteLabelForCurrentPage.Text = blinkCode;
                    noteLabelForCurrentPage.TextColor = Color.White;
                    noteLabelForCurrentPage.FontSize = 14;

                    Button copyButton = new Button();
                    copyButton.Text = "Copy";
                    copyButton.TextColor = Color.WhiteSmoke;
                    copyButton.BackgroundColor = Color.Gray;
                    copyButton.HorizontalOptions = LayoutOptions.Center;
                    copyButton.VerticalOptions = LayoutOptions.Center;
                    copyButton.WidthRequest = 100;
                    copyButton.HeightRequest = 50;

                    copyButton.Clicked += (sender, e) =>
                    {
                        TextCopy.ClipboardService.SetText(blinkCode);
                        if (ClipboardService.GetText() == blinkCode)
                        {
                            DisplayAlert("Success!", "Copied!", "OK");
                        };
                    };

                    noteCurrentPageLayout.Children.Add(headerLabelForCurrentPage);
                    noteCurrentPageLayout.Children.Add(copyButton);
                    noteCurrentPageLayout.Children.Add(noteLabelForCurrentPage);

                    noteCurrentPageView.Content = noteCurrentPageLayout;
                    noteCurrentPage.Content = noteCurrentPageView;
                    noteCurrentPage.Title = headerLabelForCurrentPage.Text;

                    await Navigation.PushAsync(noteCurrentPage);
                })
            });

            //

            MazeHeader.Text = mazeHeader;
            MazeCode.Text = mazeCode;
            Maze.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    HomePage noteCurrentPage = new HomePage();
                    ScrollView noteCurrentPageView = new ScrollView();
                    StackLayout noteCurrentPageLayout = new StackLayout();
                    noteCurrentPageLayout.BackgroundColor = Color.Black;

                    Label headerLabelForCurrentPage = new Label();
                    headerLabelForCurrentPage.Text = mazeHeader;
                    headerLabelForCurrentPage.TextColor = Color.White;
                    headerLabelForCurrentPage.HorizontalTextAlignment = TextAlignment.Center;
                    headerLabelForCurrentPage.FontSize = 26;
                    headerLabelForCurrentPage.WidthRequest = 400;
                    headerLabelForCurrentPage.HeightRequest = 100;

                    Label noteLabelForCurrentPage = new Label();
                    noteLabelForCurrentPage.Text = mazeCode;
                    noteLabelForCurrentPage.TextColor = Color.White;
                    noteLabelForCurrentPage.FontSize = 14;

                    Button copyButton = new Button();
                    copyButton.Text = "Copy";
                    copyButton.TextColor = Color.WhiteSmoke;
                    copyButton.BackgroundColor = Color.Gray;
                    copyButton.HorizontalOptions = LayoutOptions.Center;
                    copyButton.VerticalOptions = LayoutOptions.Center;
                    copyButton.WidthRequest = 100;
                    copyButton.HeightRequest = 50;

                    copyButton.Clicked += (sender, e) =>
                    {
                        TextCopy.ClipboardService.SetText(blinkCode);
                        if (ClipboardService.GetText() == blinkCode)
                        {
                            DisplayAlert("Success!", "Copied!", "OK");
                        };
                    };

                    noteCurrentPageLayout.Children.Add(headerLabelForCurrentPage);
                    noteCurrentPageLayout.Children.Add(copyButton);
                    noteCurrentPageLayout.Children.Add(noteLabelForCurrentPage);

                    noteCurrentPageView.Content = noteCurrentPageLayout;
                    noteCurrentPage.Content = noteCurrentPageView;
                    noteCurrentPage.Title = headerLabelForCurrentPage.Text;

                    await Navigation.PushAsync(noteCurrentPage);
                })
            });

            //

            BasicMiniSumoHeader.Text = basicMiniSumoHeader;
            BasicMiniSumoCode.Text = basicMiniSumoCode;
            BasicMiniSumo.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    HomePage noteCurrentPage = new HomePage();
                    ScrollView noteCurrentPageView = new ScrollView();
                    StackLayout noteCurrentPageLayout = new StackLayout();
                    noteCurrentPageLayout.BackgroundColor = Color.Black;

                    Label headerLabelForCurrentPage = new Label();
                    headerLabelForCurrentPage.Text = basicMiniSumoHeader;
                    headerLabelForCurrentPage.TextColor = Color.White;
                    headerLabelForCurrentPage.HorizontalTextAlignment = TextAlignment.Center;
                    headerLabelForCurrentPage.FontSize = 26;
                    headerLabelForCurrentPage.WidthRequest = 400;
                    headerLabelForCurrentPage.HeightRequest = 100;

                    Label noteLabelForCurrentPage = new Label();
                    noteLabelForCurrentPage.Text = basicMiniSumoCode;
                    noteLabelForCurrentPage.TextColor = Color.White;
                    noteLabelForCurrentPage.FontSize = 14;

                    Button copyButton = new Button();
                    copyButton.Text = "Copy";
                    copyButton.TextColor = Color.WhiteSmoke;
                    copyButton.BackgroundColor = Color.Gray;
                    copyButton.HorizontalOptions = LayoutOptions.Center;
                    copyButton.VerticalOptions = LayoutOptions.Center;
                    copyButton.WidthRequest = 100;
                    copyButton.HeightRequest = 50;

                    copyButton.Clicked += (sender, e) =>
                    {
                        TextCopy.ClipboardService.SetText(blinkCode);
                        if (ClipboardService.GetText() == blinkCode)
                        {
                            DisplayAlert("Success!", "Copied!", "OK");
                        };
                    };

                    noteCurrentPageLayout.Children.Add(headerLabelForCurrentPage);
                    noteCurrentPageLayout.Children.Add(copyButton);
                    noteCurrentPageLayout.Children.Add(noteLabelForCurrentPage);

                    noteCurrentPageView.Content = noteCurrentPageLayout;
                    noteCurrentPage.Content = noteCurrentPageView;
                    noteCurrentPage.Title = headerLabelForCurrentPage.Text;

                    await Navigation.PushAsync(noteCurrentPage);
                })
            });

            //

            AdvancedMiniSumoHeader.Text = advancedMiniSumoHeader;
            AdvancedMiniSumoCode.Text = advancedMiniSumoCode;
            AdvancedMiniSumo.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    HomePage noteCurrentPage = new HomePage();
                    ScrollView noteCurrentPageView = new ScrollView();
                    StackLayout noteCurrentPageLayout = new StackLayout();
                    noteCurrentPageLayout.BackgroundColor = Color.Black;

                    Label headerLabelForCurrentPage = new Label();
                    headerLabelForCurrentPage.Text = advancedMiniSumoHeader;
                    headerLabelForCurrentPage.TextColor = Color.White;
                    headerLabelForCurrentPage.HorizontalTextAlignment = TextAlignment.Center;
                    headerLabelForCurrentPage.FontSize = 26;
                    headerLabelForCurrentPage.WidthRequest = 400;
                    headerLabelForCurrentPage.HeightRequest = 100;

                    Label noteLabelForCurrentPage = new Label();
                    noteLabelForCurrentPage.Text = advancedMiniSumoCode;
                    noteLabelForCurrentPage.TextColor = Color.White;
                    noteLabelForCurrentPage.FontSize = 14;

                    Button copyButton = new Button();
                    copyButton.Text = "Copy";
                    copyButton.TextColor = Color.WhiteSmoke;
                    copyButton.BackgroundColor = Color.Gray;
                    copyButton.HorizontalOptions = LayoutOptions.Center;
                    copyButton.VerticalOptions = LayoutOptions.Center;
                    copyButton.WidthRequest = 100;
                    copyButton.HeightRequest = 50;

                    copyButton.Clicked += (sender, e) =>
                    {
                        TextCopy.ClipboardService.SetText(blinkCode);
                        if (ClipboardService.GetText() == blinkCode)
                        {
                            DisplayAlert("Success!", "Copied!", "OK");
                        };
                    };

                    noteCurrentPageLayout.Children.Add(headerLabelForCurrentPage);
                    noteCurrentPageLayout.Children.Add(copyButton);
                    noteCurrentPageLayout.Children.Add(noteLabelForCurrentPage);

                    noteCurrentPageView.Content = noteCurrentPageLayout;
                    noteCurrentPage.Content = noteCurrentPageView;
                    noteCurrentPage.Title = headerLabelForCurrentPage.Text;

                    await Navigation.PushAsync(noteCurrentPage);
                })
            });
        }
        string blinkHeader = "Blink";
        string blinkCode = "/*\r\n  Blink\r\n\r\n  Turns an LED on for one second, then off for one second, repeatedly.\r\n\r\n  Most Arduinos have an on-board LED you can control. On the UNO, MEGA and ZERO\r\n  it is attached to digital pin 13, on MKR1000 on pin 6. LED_BUILTIN is set to\r\n  the correct LED pin independent of which board is used.\r\n  If you want to know what pin the on-board LED is connected to on your Arduino\r\n  model, check the Technical Specs of your board at:\r\n  https://www.arduino.cc/en/Main/Products\r\n\r\n  modified 8 May 2014\r\n  by Scott Fitzgerald\r\n  modified 2 Sep 2016\r\n  by Arturo Guadalupi\r\n  modified 8 Sep 2016\r\n  by Colby Newman\r\n\r\n  This example code is in the public domain.\r\n\r\n  https://www.arduino.cc/en/Tutorial/BuiltInExamples/Blink\r\n*/\r\n\r\n// the setup function runs once when you press reset or power the board\r\nvoid setup() {\r\n  // initialize digital pin LED_BUILTIN as an output.\r\n  pinMode(LED_BUILTIN, OUTPUT);\r\n}\r\n\r\n// the loop function runs over and over again forever\r\nvoid loop() {\r\n  digitalWrite(LED_BUILTIN, HIGH);   // turn the LED on (HIGH is the voltage level)\r\n  delay(1000);                       // wait for a second\r\n  digitalWrite(LED_BUILTIN, LOW);    // turn the LED off by making the voltage LOW\r\n  delay(1000);                       // wait for a second\r\n}\r\n";
        string mazeHeader = "Maze Solver";
        string mazeCode = "\r\n#include <NewPing.h>\r\n\r\n#define TRIGGER_PINL  A3  // Arduino pin tied to trigger pin on ping sensor.\r\n#define ECHO_PINL     A0  // Arduino pin tied to echo pin on ping sensor.\r\n\r\n#define MAX_DISTANCE 100 // Maximum distance we want to ping for (in centimeters). Maximum sensor distance is rated at 400-500cm.\r\n\r\n#define TRIGGER_PINF  A4  // Arduino pin tied to trigger pin on ping sensor.\r\n#define ECHO_PINF     A1  // Arduino pin tied to echo pin on ping sensor.\r\n\r\n#define TRIGGER_PINR  A5  // Arduino pin tied to trigger pin on ping sensor.\r\n#define ECHO_PINR     A2  // Arduino pin tied to echo pin on ping sensor.\r\n\r\n\r\n\r\n\r\n\r\nint dir;\r\n\r\n\r\n#define STOP 0\r\n#define FORWARD 1\r\n#define BACKWARD 2\r\n#define LEFT 3\r\n#define RIGHT 4\r\n\r\n\r\n\r\nfloat P = 0.7 ;\r\nfloat D = 0.5 ;\r\nfloat I = 0.4 ;\r\nfloat oldErrorP ;\r\nfloat totalError ;\r\nint offset = 5 ;\r\n\r\nint wall_threshold = 13 ;\r\n//int left_threshold = 10 ;\r\n//int right_threshold = 10 ;\r\nint front_threshold = 7 ;\r\n\r\nboolean frontwall ;\r\nboolean leftwall ;\r\nboolean rightwall ;\r\nboolean first_turn ;\r\nboolean rightWallFollow ;\r\nboolean leftWallFollow ;\r\n\r\n\r\n\r\n\r\n\r\nint en1 = 2 ;\r\nint en2 = 3 ;\r\n\r\nint en3 = 4 ;\r\nint en4 = 5 ;\r\n\r\nint enA = 10 ;\r\nint enB = 11 ;\r\n\r\nint baseSpeed = 70 ;\r\n\r\nint RMS ;\r\nint LMS ;\r\n\r\nint LED = 13 ;\r\nint led1 = 8 ;\r\nint led2 = 9 ;\r\n\r\n\r\n\r\nNewPing sonarLeft(TRIGGER_PINL, ECHO_PINL, MAX_DISTANCE); // NewPing setup of pins and maximum distance.\r\nNewPing sonarRight(TRIGGER_PINR, ECHO_PINR, MAX_DISTANCE);\r\nNewPing sonarFront(TRIGGER_PINF, ECHO_PINF, MAX_DISTANCE);\r\n\r\nunsigned int pingSpeed = 30; // How frequently are we going to send out a ping (in milliseconds). 50ms would be 20 times a second.\r\nunsigned long pingTimer;     // Holds the next ping time.\r\n\r\n\r\nfloat oldLeftSensor, oldRightSensor, leftSensor, rightSensor, frontSensor, oldFrontSensor, lSensor, rSensor, fSensor;\r\n\r\n//int TestNUM = 1  ;\r\n\r\n\r\n\r\nvoid setup() {\r\n\r\n  Serial.begin(115200); // Open serial monitor at 115200 baud to see ping results.\r\n\r\n\r\n  for (int i = 2; i <= 13; i++) //For Motor Shield\r\n    pinMode(i, OUTPUT);\r\n\r\n\r\n\r\n  first_turn = false ;\r\n  rightWallFollow = false ;\r\n  leftWallFollow = false ;\r\n \r\n\r\n}\r\n\r\nvoid loop() {\r\n\r\n\r\n  //========================================START========================================//\r\n\r\n\r\n  ReadSensors();\r\n\r\n  walls();\r\n\r\n\r\n  if ( first_turn == false ) {\r\n\r\n    pid_start();\r\n\r\n  }\r\n  else if (leftWallFollow == true ) {\r\n\r\n    PID(true) ;\r\n\r\n  }\r\n  else if (rightWallFollow == true ) {\r\n    PID(false) ;\r\n  }\r\n\r\n\r\n  if (leftwall == true && rightwall == false && frontwall == true ) {\r\n\r\n    // turnright();\r\n    PID(false) ;\r\n\r\n    if ( first_turn == false ) {\r\n\r\n      //      right_threshold = right_threshold - offset ;\r\n      //      left_threshold = left_threshold + offset ;\r\n\r\n\r\n      first_turn = true ;\r\n      rightWallFollow = true ;\r\n      \r\n      digitalWrite(led2 , LOW );\r\n      digitalWrite(led1 ,HIGH );\r\n    }\r\n  }\r\n   if (leftwall == false && rightwall == true && frontwall == true ) {\r\n\r\n    //  turnleft();\r\n    PID(true) ;\r\n\r\n    if ( first_turn == false ) {\r\n\r\n      //      left_threshold = left_threshold - offset ;\r\n      //      right_threshold = right_threshold + offset ;\r\n\r\n      first_turn = true ;\r\n      leftWallFollow = true ;\r\n      digitalWrite(LED , HIGH);\r\n       \r\n    }\r\n  }\r\n   if ( leftSensor == 0 || leftSensor > 100 && rightSensor == 0 || rightSensor > 100 && frontSensor == 0 || frontSensor > 100 ) {\r\n\r\n    setDirection(STOP);\r\n  }\r\n\r\n\r\n\r\n  // read sensors & print the result to the serial monitor //\r\n\r\n\r\n  Serial.print(\" Left : \");\r\n  Serial.print(leftSensor);\r\n  Serial.print(\" cm \");\r\n  Serial.print(\" Right : \");\r\n  Serial.print(rightSensor);\r\n  Serial.print(\" cm \");\r\n  Serial.print(\" Front : \");\r\n  Serial.print(frontSensor);\r\n  Serial.println(\" cm \");\r\n\r\n  //measure error & print the result to the serial monitor\r\n\r\n\r\n  Serial.print(\"error=\");\r\n  Serial.println(totalError);\r\n\r\n\r\n}\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n//--------------------------------- direction control ---------------------------------//\r\n\r\nvoid setDirection(int dir) {\r\n\r\n  if ( dir == FORWARD ) {\r\n    digitalWrite(en1, LOW);   // Left wheel forward\r\n    digitalWrite(en2, HIGH);\r\n    digitalWrite(en3, LOW);  // Right wheel forward\r\n    digitalWrite(en4, HIGH);\r\n  }\r\n  else if ( dir == LEFT ) {\r\n    digitalWrite(en1, HIGH);   // Left wheel forward\r\n    digitalWrite(en2, LOW );\r\n    digitalWrite(en3, LOW );  // Right wheel forward\r\n    digitalWrite(en4, HIGH);\r\n  }\r\n  else if ( dir == RIGHT ) {\r\n    digitalWrite(en1, LOW);   // Left wheel forward\r\n    digitalWrite(en2, HIGH);\r\n    digitalWrite(en3, HIGH);  // Right wheel forward\r\n    digitalWrite(en4, LOW);\r\n  }\r\n  else if ( dir == STOP ) {\r\n    digitalWrite(en1, HIGH);   // Left wheel forward\r\n    digitalWrite(en2, HIGH );\r\n    digitalWrite(en3, HIGH );  // Right wheel forward\r\n    digitalWrite(en4, HIGH);\r\n  }\r\n  else if ( dir == BACKWARD ) {\r\n    digitalWrite(en1, HIGH );   // Left wheel forward\r\n    digitalWrite(en2, LOW );\r\n    digitalWrite(en3, HIGH );  // Right wheel forward\r\n    digitalWrite(en4, LOW );\r\n  }\r\n}\r\n//---------------------------------------------------------------------------//\r\n\r\n\r\n//--------------------------------- Sensors ---------------------------------//\r\n\r\nvoid ReadSensors() {\r\n\r\n  //leftSensor = sonarLeft.ping_median(TestNUM);     //accurate but slow\r\n  //rightSensor = sonarRight.ping_median(TestNUM);     //accurate but slow\r\n  //frontSensor = sonarFront.ping_median(TestNUM);     //accurate but slow\r\n\r\n  //leftSensor = sonarLeft.convert_cm(leftSensor);\r\n  //rightSensor = sonarRight.convert_cm(rightSensor);\r\n  //frontSensor = sonarFront.convert_cm(frontSensor);\r\n\r\n  lSensor = sonarLeft.ping_cm(); //ping in cm\r\n  rSensor = sonarRight.ping_cm();\r\n  fSensor = sonarFront.ping_cm();\r\n\r\n\r\n  leftSensor = (lSensor + oldLeftSensor) / 2; //average distance between old & new readings to make the change smoother\r\n  rightSensor = (rSensor + oldRightSensor) / 2;\r\n  frontSensor = (fSensor + oldFrontSensor) / 2;\r\n\r\n\r\n  oldLeftSensor = leftSensor; // save old readings for movment\r\n  oldRightSensor = rightSensor;\r\n  oldFrontSensor = frontSensor;\r\n\r\n}\r\n\r\n//---------------------------------------------------------------------------//\r\n\r\n\r\n//--------------------------------- control ---------------------------------//\r\n\r\nvoid pid_start() {\r\n\r\n  //ReadSensors()\r\n\r\n  float errorP = leftSensor - rightSensor ;\r\n  float errorD = errorP - oldErrorP;\r\n  float errorI = (2.0 / 3.0) * errorI + errorP ;\r\n\r\n  totalError = P * errorP + D * errorD + I * errorI ;\r\n\r\n  oldErrorP = errorP ;\r\n\r\n\r\n  RMS = baseSpeed + totalError ;\r\n  LMS = baseSpeed - totalError ;\r\n\r\n  //  if(RMS < -255) RMS = -255; if(RMS > 255)RMS = 255 ;\r\n  //  if(LMS < -255) LMS = -255;  if(LMS > 255)LMS = 255 ;\r\n\r\n\r\n  if (RMS < 0) {\r\n\r\n    RMS = map(RMS , 0 , -255, 0, 255);\r\n\r\n    analogWrite(enA , RMS);\r\n    analogWrite(enB , LMS);\r\n\r\n    setDirection(RIGHT);\r\n\r\n  }\r\n  else if (LMS < 0) {\r\n    LMS = map(LMS , 0 , -255, 0, 255);\r\n\r\n\r\n    analogWrite(enA , RMS);\r\n    analogWrite(enB , LMS);\r\n\r\n    setDirection(LEFT);\r\n  }\r\n  else {\r\n\r\n    analogWrite(enA , RMS);\r\n    analogWrite(enB , LMS);\r\n\r\n    setDirection(FORWARD);\r\n  }\r\n\r\n\r\n\r\n}\r\n\r\n\r\n//----------------------------- wall follow  control -------------------------------//\r\n\r\nvoid PID( boolean left ) {\r\n\r\n  if (left == true ) {\r\n\r\n    float errorP = leftSensor - rightSensor - offset ;\r\n    float errorD = errorP - oldErrorP;\r\n    float errorI = (2.0 / 3) * errorI + errorP ;\r\n\r\n\r\n    totalError = P * errorP + D * errorD + I * errorI ;\r\n\r\n    oldErrorP = errorP ;\r\n\r\n\r\n    RMS = baseSpeed + totalError ;\r\n    LMS = baseSpeed - totalError ;\r\n\r\n    //  if(RMS < -255) RMS = -255; if(RMS > 255)RMS = 255 ;\r\n    //  if(LMS < -255) LMS = -255;  if(LMS > 255)LMS = 255 ;\r\n\r\n\r\n    if (RMS < 0) {\r\n\r\n      RMS = map(RMS , 0 , -255, 0, 255);\r\n\r\n      analogWrite(enA , RMS);\r\n      analogWrite(enB , LMS);\r\n\r\n      setDirection(RIGHT);\r\n\r\n    }\r\n    else if (LMS < 0) {\r\n      LMS = map(LMS , 0 , -255, 0, 255);\r\n\r\n\r\n      analogWrite(enA , RMS);\r\n      analogWrite(enB , LMS);\r\n\r\n      setDirection(LEFT);\r\n    }\r\n    else {\r\n\r\n      analogWrite(enA , RMS);\r\n      analogWrite(enB , LMS);\r\n\r\n      setDirection(FORWARD);\r\n    }\r\n\r\n  }\r\n  else {\r\n\r\n    float errorP = leftSensor - rightSensor + offset ;\r\n    float errorD = errorP - oldErrorP;\r\n    float errorI = (2.0 / 3) * errorI + errorP ;\r\n\r\n    totalError = P * errorP + D * errorD + I * errorI ;\r\n\r\n    oldErrorP = errorP ;\r\n\r\n\r\n    RMS = baseSpeed + totalError ;\r\n    LMS = baseSpeed - totalError ;\r\n\r\n    //  if(RMS < -255) RMS = -255; if(RMS > 255)RMS = 255 ;\r\n    //  if(LMS < -255) LMS = -255;  if(LMS > 255)LMS = 255 ;\r\n\r\n\r\n    if (RMS < 0) {\r\n\r\n      RMS = map(RMS , 0 , -255, 0, 255);\r\n\r\n      analogWrite(enA , RMS);\r\n      analogWrite(enB , LMS);\r\n\r\n      setDirection(RIGHT);\r\n\r\n    }\r\n    else if (LMS < 0) {\r\n      LMS = map(LMS , 0 , -255, 0, 255);\r\n\r\n\r\n      analogWrite(enA , RMS);\r\n      analogWrite(enB , LMS);\r\n\r\n      setDirection(LEFT);\r\n    }\r\n    else {\r\n\r\n      analogWrite(enA , RMS);\r\n      analogWrite(enB , LMS);\r\n\r\n      setDirection(FORWARD);\r\n    }\r\n\r\n  }\r\n\r\n}\r\n\r\n//--------------------------- wall detection --------------------------------//\r\n\r\nvoid walls() {\r\n\r\n\r\n  if ( leftSensor < wall_threshold ) {\r\n    leftwall = true ;\r\n  }\r\n  else {\r\n    leftwall = false ;\r\n  }\r\n\r\n\r\n  if ( rightSensor < wall_threshold ) {\r\n    rightwall = true ;\r\n  }\r\n  else {\r\n    rightwall = false ;\r\n\r\n\r\n  } if ( frontSensor < front_threshold ) {\r\n    frontwall = true ;\r\n  }\r\n  else {\r\n    frontwall = false ;\r\n  }\r\n\r\n}\r\n\r\n\r\n\r\n//---------------------------------------------------------------------------//\r\n\r\nvoid turnright() {\r\n\r\n\r\n  LMS = baseSpeed ;\r\n\r\n  RMS = LMS * rightSensor / ( rightSensor + 11 ) ;\r\n\r\n\r\n}\r\n\r\n//---------------------------------------------------------------------------//\r\n\r\nvoid turnleft() {\r\n\r\n\r\n  RMS = baseSpeed ;\r\n\r\n  LMS = RMS * leftSensor / ( leftSensor + 11 ) ;\r\n\r\n}\r\n\r\n\r\n//---------------------------------------------------------------------------//\r\n\r\n\r\n\r\n";
        string basicMiniSumoHeader = "Basic Mini Sumo";
        string basicMiniSumoCode = "/*\r\n Author: Nate Lawernce-Richards\r\n  Description: This is the basic run code that is used for a mini sumo match\r\n*/\r\n\r\n#include <Servo.h> // Include servo library, see file/examples/servo in the menu for more information\r\n\r\nServo servoR; // Declare servo variables\r\nServo servoL;\r\n\r\n// Set vaules for pin in variables\r\n#define servoR_pin 10 // Servos\r\n#define servoL_pin 11\r\n#define lineR_pin 5   // Line sensors\r\n#define lineL_pin 4\r\n#define midR_pin A5   // Midrange sensors\r\n#define midL_pin A4\r\n#define prox_pin 6    // Proximity Sensor\r\n#define button_Pin 9  // Start button\r\n#define LED1_pin 12   // LED 2\r\n#define LED2_pin 13   // LED 1\r\n\r\n// Declare varibles for future use with sensors\r\n// int is used because these values will be an interger and will change\r\nint lineL;\r\nint lineR;\r\nint prox;\r\nint midR;\r\nint midL;\r\n\r\nint threshold = 200; /* Thresholdold for confirmed analog hit, derived from experimental testing\r\n                     Larger numbers mean the target is closer */\r\n\r\nint buttonState = HIGH; // The initial state of the button\r\n\r\n\r\n// Set up loop, runs once to initialize the controller\r\nvoid setup() {\r\n  pinMode(lineR_pin, INPUT);         // Declare pinmode for line tracking\r\n  pinMode(lineL_pin, INPUT);\r\n  pinMode(midR_pin, INPUT);          // Declare pinmode for midrange sensors\r\n  pinMode(midL_pin, INPUT);\r\n  pinMode(prox_pin, INPUT);          // Declare pinmode for proximity detector\r\n  pinMode(button_Pin, INPUT_PULLUP); // Declare pinmode for start button\r\n  pinMode(LED1_pin, OUTPUT);\r\n  pinMode(LED2_pin, OUTPUT);\r\n\r\n  while(buttonState == HIGH) { // While the button isn't pressed, the robot just sits there, you can run loops in setup\r\n    digitalWrite(LED1_pin, HIGH); // LED is on so you know the robot is ready\r\n    buttonState = digitalRead(button_Pin); // Keep checking to see if the button is pressed\r\n  }\r\n  digitalWrite(LED1_pin, LOW); // After the condition is met the loop ends, LED goes off to indicate this\r\n  delay(5000);                 // Now wait 5 sec, dealy is in milisecond\r\n  servoR.attach(servoR_pin);   // Attaches the servo on pin (defined earlier) to the servo object\r\n  servoL.attach(servoL_pin);   // You attach the servos after the 5 second wait so they won't move at all before time is up, in case they aren't calibrated properly\r\n}\r\n\r\n// Main loop, this will run continuously until the controller is reset\r\nvoid loop() {\r\n\r\n  sensors(); // This function is defined below and checks the values of the sensors\r\n\r\n  /* After sensors are checked the code is one big \"else if\" loop\r\n  the hierarchy is decided by the importance of conditions, if the front proximity sensor is tripped then the opponet is right in front\r\n  no need to check any other cases at this point so the loop ends and starts over again\r\n  otherwise the loop progresses to the midrange sensors and then the line sensors\r\n  */\r\n\r\n  // Target in front\r\n  if (prox == LOW) { // The front proximity sensor goes low when it detects an object\r\n    motors(100, 100); // Sets motors to drive full forward\r\n  }\r\n  // Both spot\r\n  else if (midR > threshold && midL > threshold) { // Both mid range sensors are above the detection threshold\r\n    motors(100, 100);  // Full foward\r\n  }\r\n  else if (midL > threshold && midR < threshold) {  // Only mid L spots\r\n    motors(-100, 100);  // Turns left\r\n  }\r\n  else if (midR > threshold && midL < threshold) {  // Only mid R spots\r\n    motors(100, -100);  // Turns right\r\n  }\r\n  // No robots, time to check to see if you are driving out of the arena\r\n  else if (lineR == HIGH && lineL == HIGH) {   // If both line sensors are on black, full ahead\r\n    motors(100, 100);\r\n  }\r\n  else if (lineR == LOW && lineL == HIGH) { // Right line sensor hits the white line and triggers low\r\n    motors(-100, -100); // Back up\r\n    delay(300);        // Only back up for .3 seconds\r\n    motors(-100, 100);  // Spin away from edge\r\n    delay(400);        // Keep spinning for .4 seconds to turn around\r\n  }\r\n  else if (lineR == HIGH && lineL == LOW) { // Left line sensor hits\r\n    motors(-100, -100);\r\n    delay(300);\r\n    motors(100, -100);\r\n    delay(400);\r\n  }\r\n  else if(lineR == LOW && lineL == LOW) {  // Both sensors are over the line, not a good position\r\n    motors(-100, -100);\r\n    delay(300);\r\n    motors(-100, 100);\r\n    delay(400);\r\n  }\r\n  else { // If for some reason no conditions trigger keep going forward, just a backup for the unseen\r\n    motors(100, 100);\r\n  }\r\n\r\n  delay(10); // A slight delay at the end of the code is good for stability, and prevents jitery movement.\r\n} //end loop\r\n\r\n\r\n//-----------------------------------------------------------------------------------------------------------------------------------\r\n// Functions, normaly these are put in a header file, but are placed here for your convience\r\n//-----------------------------------------------------------------------------------------------------------------------------------\r\n\r\n// Sensor check\r\nvoid sensors() {\r\n  midR = analogRead(midR_pin);\r\n  midL = analogRead(midL_pin);\r\n  prox = digitalRead(prox_pin);\r\n  lineR = digitalRead(lineR_pin);\r\n  lineL = digitalRead(lineL_pin);\r\n}\r\n\r\n// Prints off all sensor values to serial port, in the default version of this code the serial funtion is not used\r\nvoid sensors_print() {\r\n  Serial.print(\"Midrange Right = \");\r\n  Serial.println(midR);\r\n  Serial.print(\"Midrange Left = \");\r\n  Serial.println(midL);\r\n  Serial.print(\"Proximity = \");\r\n  Serial.println(prox);\r\n  Serial.print(\"Right Line Sensor = \");\r\n  Serial.println(lineR);\r\n  Serial.print(\"Left Line Sensor = \");\r\n  Serial.println(lineL);\r\n}\r\n\r\n// This funtion is used to control the motors\r\nvoid motors(int l, int r) {      // Syntax motors(left motor value, right motor value)\r\n  r = map(r, -100, 100, 180, 0); // Normal servo library uses 0 to 180 to define postion for a regular servo\r\n  l = map(l, -100, 100, 0, 180); // We have modified our servos for continuous rotation so 0 is full back, 180 is full forward, and 90 is stop\r\n  servoL.write(l);               // This is remapped to -100 to 100 for convenience and flipped for one motor because it will me mounted backwards on the chassis\r\n  servoR.write(r);\r\n}";
        string advancedMiniSumoHeader = "Advanced Mini Sumo";
        string advancedMiniSumoCode = "/*\r\n Created by Nate Lawernce-Richards for the University of Northern Iowa\r\n Description: This is the same program as the basic run code, but it is a bit smarter\r\n*/\r\n\r\n#include <Servo.h> // Include servo library\r\n\r\nServo servoR;  // Declare servo variables\r\nServo servoL;\r\n\r\n// Set vaules for pin in variables\r\n#define servoR_pin 10 // Servos\r\n#define servoL_pin 11\r\n#define lineR_pin 5   // Line Sensors\r\n#define lineL_pin 4\r\n#define midR_pin A5   // Midrange Sensors\r\n#define midL_pin A4\r\n#define prox_pin 6    // Proximity Sensor\r\n#define button_Pin 9  // Start button\r\n#define LED1_pin 12   // LED 2\r\n#define LED2_pin 13   // LED 1\r\n\r\n// Declare varibles for future use with sensors\r\n// int is used because these values will be an interger and will change\r\nint lineL;\r\nint lineR;\r\nint prox;\r\nint midR;\r\nint midL;\r\n\r\n// For running the timer\r\nunsigned long end_time;\r\n\r\nint threshold = 125; /* Thresholdold for confirmed analog hit, derived from\r\n                        experimental testing Larger numbers mean the target is closer */\r\n\r\nint buttonState = HIGH; // The initial state of the button\r\n\r\n// For averaging\r\n#define numReadings 10\r\nint index = 0;\r\n\r\n// For midR averaging\r\nint midR_readings[numReadings];\r\nint midR_total = 0;\r\nint midR_avg = 0;\r\n\r\n// For midL averaging\r\nint midL_readings[numReadings];\r\nint midL_total = 0;\r\nint midL_avg = 0;\r\n\r\n\r\n\r\n// Set up loop, runs once to initialize the controller\r\nvoid setup() {\r\n  pinMode(lineR_pin, INPUT);         // Declare pinmode for line tracking\r\n  pinMode(lineL_pin, INPUT);\r\n  pinMode(midR_pin, INPUT);          // Declare pinmode for midrange sensors\r\n  pinMode(midL_pin, INPUT);\r\n  pinMode(prox_pin, INPUT);          // Declare pinmode for proximity detector\r\n  pinMode(button_Pin, INPUT_PULLUP); // Declare pinmode for start button\r\n  pinMode(LED1_pin, OUTPUT);\r\n  pinMode(LED2_pin, OUTPUT);\r\n\r\n  // Initialize midR array\r\n  for (int thisReading = 0; thisReading < numReadings; thisReading++)\r\n    midR_readings[thisReading] = 0;\r\n\r\n  // Initialize midL array\r\n  for (int thisReading = 0; thisReading < numReadings; thisReading++)\r\n    midL_readings[thisReading] = 0;\r\n\r\n  while(buttonState == HIGH) { // While the button isn't pressed, the robot just sits there, you can run loops in setup\r\n    digitalWrite(LED1_pin, HIGH); // LED is on so you know the robot is ready\r\n    buttonState = digitalRead(button_Pin); // Keep checking to see if the button is pressed\r\n  }\r\n\r\n  digitalWrite(LED1_pin, LOW); // After the condition is met the loop ends, LED goes off to indicate this\r\n  delay(5000);                 // Now wait 5 sec, dealy is in milisecond\r\n  servoR.attach(servoR_pin);   // Attaches the servo on pin (defined earlier) to the servo object\r\n  servoL.attach(servoL_pin);   // You attach the servos after the 5 second wait so they won't move at all before time is up, in case they aren't calibrated properly\r\n\r\n // Serial.begin(9600); //uncomment if using serial communication\r\n}\r\n\r\n// Main loop, this will run continuously until the controller is reset\r\nvoid loop() {\r\n\r\n  sensors();\r\n\r\n  // Average out the sensor data from the midranges\r\n  // Mid R averaging\r\n  midR_total = midR_total - midR_readings[index];\r\n  // Read from the sensor:\r\n  midR_readings[index] = midR;\r\n  // Add the reading to the midR_total:\r\n  midR_total = midR_total + midR_readings[index];\r\n  // Advance to the next position in the array:\r\n  midR_avg = midR_total / numReadings;\r\n\r\n  // Mid L averaging\r\n  midL_total = midL_total - midL_readings[index];\r\n  // Read from the sensor:\r\n  midL_readings[index] = midL;\r\n  // Add the reading to the midL_total:\r\n  midL_total= midL_total + midL_readings[index];\r\n  // Advance to the next position in the array:\r\n  midL_avg = midL_total / numReadings;\r\n\r\n  // Progress the index\r\n  index = index + 1;\r\n  // If we're at the end of the array...\r\n  if (index >= numReadings) {\r\n    // ...wrap around to the beginning:\r\n    index = 0;\r\n  }\r\n\r\n  // Target in front\r\n  if (prox == LOW){ // The front proximity sensor goes low when it detects an object\r\n    motors(100, 100); // Sets motors to drive full forward\r\n    digitalWrite(LED1_pin, HIGH);\r\n    digitalWrite(LED2_pin, HIGH);\r\n    delay(50);\r\n  }\r\n\r\n  // Midrange Sensor checks\r\n  else if (midR_avg > threshold && midL_avg > threshold) { // Both mid range sensors are above the detection threshold\r\n    motors(100,100);  // Full foward\r\n    digitalWrite(LED1_pin, HIGH);\r\n    digitalWrite(LED2_pin, HIGH);\r\n  }\r\n\r\n  else if (midL_avg > threshold && midR_avg < threshold) { // Only mid L spots\r\n    motors(-20,100);  // Turn left\r\n    digitalWrite(LED2_pin, HIGH); // Signal with left LED\r\n    digitalWrite(LED1_pin, LOW);\r\n  }\r\n\r\n\r\n  else if (midR_avg > threshold && midL_avg < threshold) { // Only midR spots\r\n    motors(100,-20); // Turn right\r\n    digitalWrite(LED1_pin, HIGH); // Signal with right LED\r\n    digitalWrite(LED2_pin, LOW);\r\n  }\r\n\r\n  // No robots, time to check to see if you are driving out of the arena\r\n\r\n  else if (lineR == HIGH && lineL == HIGH) {   // If both line sensor are on black, full ahead\r\n    motors(100,100);\r\n    digitalWrite(LED1_pin, LOW);\r\n    digitalWrite(LED2_pin, LOW);\r\n  }\r\n\r\n  else if (lineR == LOW && lineL == HIGH) { // Right line sensor hits the white line and triggers low\r\n    motors(-100, -100);           // Back up\r\n    delay(200);                  // Only back up for .2 seconds\r\n    end_time = millis() + 400;   // Find the time 400 miliseconds into the future\r\n    while(millis() < end_time) { // Spin away from edge untill the time limit is hit\r\n      motors(-100, 100);\r\n      sensors();\r\n      if(midL > threshold || midR > threshold || prox == LOW){  // If you see a target, break loop\r\n        break;\r\n      }\r\n      digitalWrite(LED1_pin, LOW);\r\n      digitalWrite(LED2_pin, LOW);\r\n    }\r\n  }\r\n\r\n  else if (lineR == HIGH && lineL == LOW) { // Left line sensor hits\r\n    motors(-100, -100);  // Back up\r\n    delay(200);        // Only back up for .2 seconds\r\n    end_time = millis() + 400;\r\n    while(millis() < end_time) {\r\n      motors(100, -100);  //spin away from edge\r\n      sensors();\r\n      digitalWrite(LED1_pin, LOW);\r\n      digitalWrite(LED2_pin, LOW);\r\n      if(midL > threshold || midR > threshold || prox == LOW){\r\n        break;\r\n      }\r\n      digitalWrite(LED1_pin, LOW);\r\n      digitalWrite(LED2_pin, LOW);\r\n    }\r\n  }\r\n\r\n  else if(lineR == LOW && lineL == LOW) { // Both sensors are on the line, not a good position\r\n    motors(-100, -100);  // Back up\r\n    delay(200);        // Only back up for .2 seconds\r\n    end_time = millis() + 400;\r\n    while(millis() < end_time){\r\n      motors(-100, 100);  // Spin away from edge\r\n      sensors();\r\n      if(midL > threshold || midR > threshold || prox == LOW){\r\n        break;\r\n      }\r\n      digitalWrite(LED1_pin, LOW);\r\n      digitalWrite(LED2_pin, LOW);\r\n    }\r\n  }\r\n\r\n  else { // For some reason no conditions trigger keep going forward, just a backup for the unseen because I'm a bit paranoid with my code, there is no reason for this condition to occur\r\n    motors(100, 100);\r\n    digitalWrite(LED1_pin, LOW);\r\n    digitalWrite(LED2_pin, LOW);\r\n  }\r\n\r\n  delay(5); // A slight delay at the end of the code is good for stability, and prevents jitery movement.\r\n} // end loop\r\n\r\n\r\n//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n// Functions, normaly these are put in a header file, but are placed here for your convience\r\n//----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n\r\n\r\n// This function reads all of the values from the sensors\r\nvoid sensors() {\r\n  midR = analogRead(midR_pin);\r\n  midL = analogRead(midL_pin);\r\n  prox = digitalRead(prox_pin);\r\n  lineR = digitalRead(lineR_pin);\r\n  lineL = digitalRead(lineL_pin);\r\n}\r\n\r\n// Prints off all sensor values to serial port, in the default version of this code the serial funtion is not used\r\nvoid sensors_print() {\r\n  Serial.print(\"Midrange Right = \");\r\n  Serial.println(midR);\r\n  Serial.print(\"Midrange Right Average = \");\r\n  Serial.println(midR_avg);\r\n  Serial.print(\"Midrange Left = \");\r\n  Serial.println(midL);\r\n  Serial.print(\"Midrange Left Average = \");\r\n  Serial.println(midL_avg);\r\n  Serial.print(\"Prxoimity = \");\r\n  Serial.println(prox);\r\n  Serial.print(\"Right Line Sensor = \");\r\n  Serial.println(lineR);\r\n  Serial.print(\"Left Line Sensor = \");\r\n  Serial.println(lineL);\r\n  Serial.println(\"--------------------------------------\");\r\n}\r\n\r\n// This funtion is used to control the motors\r\nvoid motors(int l, int r) {      // Syntax motors(left motor value, right motor value)\r\n  r = map(r, -100, 100, 180, 0); // Normal servo library uses 0 to 180 to define postion for a regular servo\r\n  l = map(l, -100, 100, 0, 180); // We have modified our servos for continuous rotation so 0 is full back, 180 is full forward, and 90 is stop\r\n  servoL.write(l);               // This is remapped to -100 to 100 for convenience and flipped for one motor because it will me mounted backwards on the chassis\r\n  servoR.write(r);\r\n}";
    }
}