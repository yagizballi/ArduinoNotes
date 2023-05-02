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

            TrafikLambasiHeader.Text = trafikLambasiHeader;
            TrafikLambasiDesc.Text = trafikLambasiDesc;
            TrafikLambasi.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    HomePage noteCurrentPage = new HomePage();
                    ScrollView noteCurrentPageView = new ScrollView();
                    StackLayout noteCurrentPageLayout = new StackLayout();
                    noteCurrentPageLayout.BackgroundColor = Color.Black;

                    Label headerLabelForCurrentPage = new Label();
                    headerLabelForCurrentPage.Text = trafikLambasiHeader;
                    headerLabelForCurrentPage.TextColor = Color.White;
                    headerLabelForCurrentPage.HorizontalTextAlignment = TextAlignment.Center;
                    headerLabelForCurrentPage.FontSize = 26;
                    headerLabelForCurrentPage.WidthRequest = 400;
                    headerLabelForCurrentPage.HeightRequest = 50;

                    WebView video = new WebView();
                    video.Source = "https://maker.robotistan.com/wp-content/uploads/2023/03/trafik-lambasi-proje-video.mp4";
                    video.VerticalOptions = LayoutOptions.CenterAndExpand;
                    video.HeightRequest = 200;

                    Image robotSchema = new Image();
                    robotSchema.Source = "trafiklambasi.png";

                    Label circuitElements = new Label();
                    circuitElements.Text = trafikDevreElemanlari;
                    circuitElements.TextColor = Color.White;
                    circuitElements.HorizontalTextAlignment = TextAlignment.Center;
                    circuitElements.FontSize = 13;
                    circuitElements.WidthRequest = 400;
                    circuitElements.HeightRequest = 150;

                    Label noteLabelForCurrentPage = new Label();
                    noteLabelForCurrentPage.Text = trafikLambasiCode;
                    noteLabelForCurrentPage.TextColor = Color.White;
                    noteLabelForCurrentPage.FontSize = 14;

                    Button copyButton = new Button();
                    copyButton.Text = "Kopyala";
                    copyButton.TextColor = Color.WhiteSmoke;
                    copyButton.BackgroundColor = Color.Gray;
                    copyButton.HorizontalOptions = LayoutOptions.Center;
                    copyButton.VerticalOptions = LayoutOptions.Center;
                    copyButton.WidthRequest = 100;
                    copyButton.HeightRequest = 50;

                    copyButton.Clicked += (sender, e) =>
                    {
                        TextCopy.ClipboardService.SetText(trafikLambasiCode);
                        if (ClipboardService.GetText() == trafikLambasiCode)
                        {
                            DisplayAlert("Başarılı!", "Kopyalandı!", "Tamam");
                        };
                    };

                    noteCurrentPageLayout.Children.Add(headerLabelForCurrentPage);
                    noteCurrentPageLayout.Children.Add(circuitElements);
                    noteCurrentPageLayout.Children.Add(video);
                    noteCurrentPageLayout.Children.Add(robotSchema);
                    noteCurrentPageLayout.Children.Add(copyButton);
                    noteCurrentPageLayout.Children.Add(noteLabelForCurrentPage);

                    noteCurrentPageView.Content = noteCurrentPageLayout;
                    noteCurrentPage.Content = noteCurrentPageView;
                    noteCurrentPage.Title = headerLabelForCurrentPage.Text;

                    await Navigation.PushAsync(noteCurrentPage);
                })
            });

            //

            LdrHeader.Text = ldrHeader;
            LdrDesc.Text = ldrDesc;
            ldrAydinlatma.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    HomePage noteCurrentPage = new HomePage();
                    ScrollView noteCurrentPageView = new ScrollView();
                    StackLayout noteCurrentPageLayout = new StackLayout();
                    noteCurrentPageLayout.BackgroundColor = Color.Black;

                    Label headerLabelForCurrentPage = new Label();
                    headerLabelForCurrentPage.Text = ldrHeader;
                    headerLabelForCurrentPage.TextColor = Color.White;
                    headerLabelForCurrentPage.HorizontalTextAlignment = TextAlignment.Center;
                    headerLabelForCurrentPage.FontSize = 26;
                    headerLabelForCurrentPage.WidthRequest = 400;
                    headerLabelForCurrentPage.HeightRequest = 50;

                    WebView video = new WebView();
                    video.Source = "https://maker.robotistan.com/wp-content/uploads/2023/03/ldr-ile-akilli-aydinlatma.mp4";
                    video.VerticalOptions = LayoutOptions.CenterAndExpand;
                    video.HeightRequest = 200;

                    Image robotSchema = new Image();
                    robotSchema.Source = "ldr.png";

                    Label circuitElements = new Label();
                    circuitElements.Text = ldrDevreElemanlari;
                    circuitElements.TextColor = Color.White;
                    circuitElements.HorizontalTextAlignment = TextAlignment.Center;
                    circuitElements.FontSize = 13;
                    circuitElements.WidthRequest = 400;
                    circuitElements.HeightRequest = 150;

                    Label noteLabelForCurrentPage = new Label();
                    noteLabelForCurrentPage.Text = ldrCode;
                    noteLabelForCurrentPage.TextColor = Color.White;
                    noteLabelForCurrentPage.FontSize = 14;

                    Button copyButton = new Button();
                    copyButton.Text = "Kopyala";
                    copyButton.TextColor = Color.WhiteSmoke;
                    copyButton.BackgroundColor = Color.Gray;
                    copyButton.HorizontalOptions = LayoutOptions.Center;
                    copyButton.VerticalOptions = LayoutOptions.Center;
                    copyButton.WidthRequest = 100;
                    copyButton.HeightRequest = 50;

                    copyButton.Clicked += (sender, e) =>
                    {
                        TextCopy.ClipboardService.SetText(ldrCode);
                        if (ClipboardService.GetText() == ldrCode)
                        {
                            DisplayAlert("Başarılı!", "Kopyalandı!", "Tamam");
                        };
                    };

                    noteCurrentPageLayout.Children.Add(headerLabelForCurrentPage);
                    noteCurrentPageLayout.Children.Add(circuitElements);
                    noteCurrentPageLayout.Children.Add(video);
                    noteCurrentPageLayout.Children.Add(robotSchema);
                    noteCurrentPageLayout.Children.Add(copyButton);
                    noteCurrentPageLayout.Children.Add(noteLabelForCurrentPage);

                    noteCurrentPageView.Content = noteCurrentPageLayout;
                    noteCurrentPage.Content = noteCurrentPageView;
                    noteCurrentPage.Title = headerLabelForCurrentPage.Text;

                    await Navigation.PushAsync(noteCurrentPage);
                })
            });

            //

            DepremHeader.Text = depremHeader;
            DepremDesc.Text = depremDesc;
            depremAlarmi.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(async () =>
                {
                    HomePage noteCurrentPage = new HomePage();
                    ScrollView noteCurrentPageView = new ScrollView();
                    StackLayout noteCurrentPageLayout = new StackLayout();
                    noteCurrentPageLayout.BackgroundColor = Color.Black;

                    Label headerLabelForCurrentPage = new Label();
                    headerLabelForCurrentPage.Text = depremHeader;
                    headerLabelForCurrentPage.TextColor = Color.White;
                    headerLabelForCurrentPage.HorizontalTextAlignment = TextAlignment.Center;
                    headerLabelForCurrentPage.FontSize = 26;
                    headerLabelForCurrentPage.WidthRequest = 400;
                    headerLabelForCurrentPage.HeightRequest = 50;

                    WebView video = new WebView();
                    video.Source = "https://maker.robotistan.com/wp-content/uploads/2023/03/deprem-sensoru.mp4";
                    video.VerticalOptions = LayoutOptions.CenterAndExpand;
                    video.HeightRequest = 200;

                    Image robotSchema = new Image();
                    robotSchema.Source = "deprem.jpeg";

                    Label circuitElements = new Label();
                    circuitElements.Text = depremDevreElemanlari;
                    circuitElements.TextColor = Color.White;
                    circuitElements.HorizontalTextAlignment = TextAlignment.Center;
                    circuitElements.FontSize = 13;
                    circuitElements.WidthRequest = 400;
                    circuitElements.HeightRequest = 150;

                    Label noteLabelForCurrentPage = new Label();
                    noteLabelForCurrentPage.Text = depremCode;
                    noteLabelForCurrentPage.TextColor = Color.White;
                    noteLabelForCurrentPage.FontSize = 14;

                    Button copyButton = new Button();
                    copyButton.Text = "Kopyala";
                    copyButton.TextColor = Color.WhiteSmoke;
                    copyButton.BackgroundColor = Color.Gray;
                    copyButton.HorizontalOptions = LayoutOptions.Center;
                    copyButton.VerticalOptions = LayoutOptions.Center;
                    copyButton.WidthRequest = 100;
                    copyButton.HeightRequest = 50;

                    copyButton.Clicked += (sender, e) =>
                    {
                        TextCopy.ClipboardService.SetText(depremCode);
                        if (ClipboardService.GetText() == depremCode)
                        {
                            DisplayAlert("Başarılı!", "Kopyalandı!", "Tamam");
                        };
                    };

                    noteCurrentPageLayout.Children.Add(headerLabelForCurrentPage);
                    noteCurrentPageLayout.Children.Add(circuitElements);
                    noteCurrentPageLayout.Children.Add(video);
                    noteCurrentPageLayout.Children.Add(robotSchema);
                    noteCurrentPageLayout.Children.Add(copyButton);
                    noteCurrentPageLayout.Children.Add(noteLabelForCurrentPage);

                    noteCurrentPageView.Content = noteCurrentPageLayout;
                    noteCurrentPage.Content = noteCurrentPageView;
                    noteCurrentPage.Title = headerLabelForCurrentPage.Text;

                    await Navigation.PushAsync(noteCurrentPage);
                })
            });
        }
        string trafikLambasiHeader = "Trafik Lambası";
        string trafikLambasiCode = "#include <Arduino.h>\r\n\r\n#define kirmizi 6; \r\n#define sari 5; \r\n#define yesil 3; \r\n\r\nvoid setup() {\r\n  Serial.begin(9600);\r\n  pinMode(6,OUTPUT);\r\n  pinMode(5,OUTPUT);\r\n  pinMode(3,OUTPUT);\r\n}\r\n\r\nvoid loop() {\r\n  \r\n// while true sayesinde döngü sonsuza kadar devam eder. \r\n  while (true) {    \r\n    digitalWrite(6,HIGH); // kırmızı ışığı yaktık.\r\n    delay(4000);\r\n    digitalWrite(6,LOW); // kırmızı ışığı kapattık. \r\n    digitalWrite(5,HIGH); // Sarı ışığı yaktık.\r\n    delay(2500); \r\n    digitalWrite(5,LOW); // Sarı ışığı kapattık.\r\n    digitalWrite(3,HIGH); // Yeşil ışığı yaktık. \r\n    delay(3000);\r\n    digitalWrite(3,LOW); // Yeşil ışığı kapattık.\r\n    digitalWrite(5,HIGH); // Sarı ışığı yaktık.\r\n    delay(2500);\r\n    digitalWrite(5,LOW); // Sarı ışığı kapattık.\r\n    digitalWrite(6,HIGH); // kırmızı ışığı yaktık. \r\n    delay(2000);\r\n  } \r\n  \r\n}";
        string trafikLambasiDesc = "Bu içeriğimizde basit ama eğlenceli bir proje olan trafik lambası yapımını öğreneceğiz.  Sırasıyla kırmızı, sarı, yeşil olan LED’ler sırasıyla yanar ve söner. Yeşil yanıp söndükten sonra tekrar sarı ve kırmızı şeklinde döngü sonsuza kadar devam eder.";
        string trafikDevreElemanlari = "Kırmızı LED \r\nSarı LED \r\nYeşil LED \r\nDirenç \r\nBreadboard Mini \r\nJumper Kablo \r\nArduino UNO";
        string ldrHeader = "LDR ile Akıllı Aydınlatma";
        string ldrCode = "#include <Arduino.h>\r\n\r\n#define led1 11\r\n#define led2 10\r\n#define led3 9\r\n#define led4 6\r\n#define led5 5\r\n#define led6 3\r\n\r\nvoid setup() {\r\n  Serial.begin(9600);\r\n  pinMode(led1,OUTPUT);\r\n  pinMode(led2,OUTPUT);\r\n  pinMode(led3,OUTPUT);\r\n  pinMode(led4,OUTPUT);\r\n  pinMode(led5,OUTPUT);\r\n  pinMode(led6,OUTPUT);\r\n}\r\nvoid loop() {\r\n  int isik = analogRead(A0);\r\n  \r\n  if (isik > 200) {\r\n    delay(250);\r\n    digitalWrite(led1,LOW);\r\n    digitalWrite(led2,LOW);\r\n    digitalWrite(led3,LOW);\r\n    digitalWrite(led4,LOW);\r\n    digitalWrite(led5,LOW);\r\n    digitalWrite(led6,LOW);\r\n  } else if (isik<200){\r\n\r\n    digitalWrite(led1,HIGH);\r\n    digitalWrite(led2,HIGH);\r\n    digitalWrite(led3,HIGH);\r\n    digitalWrite(led4,HIGH);\r\n    digitalWrite(led5,HIGH);\r\n    digitalWrite(led6,HIGH);\r\n  }\r\n}";
        string ldrDesc = "Herkesin bildiği üzere bu zamanlar elimizden geldiğince her şeyin akıllısını kullanmaya çalışıyoruz. Bu trendlerden bir tanesi de akıllı aydınlatma sistemleri. Bir hayli popüler olan bu sisteme örnek olarak akıllı merdiven aydınlatma sistemini ve akıllı sokak aydınlatma sistemini verebiliriz.";
        string ldrDevreElemanlari = "LDR 5mm\r\nSarı LED\r\nDirenç \r\nArduino Uno\r\nBreadboard \r\nJumper Kablo";
        string depremHeader = "Deprem Alarmı";
        string depremCode = "#include <MPU6050.h>\r\n#include <Wire.h>\r\nMPU6050 MPU;\r\nint GyroX , GyroY , GyroZ;\r\nint buzzer = 10;\r\nvoid setup() {\r\n  pinMode(11,OUTPUT); \r\n  Serial.begin(9600);\r\n  Wire.begin();\r\n  MPU.initialize();\r\n}\r\nvoid loop() {\r\n  MPU.getRotation(&GyroX, &GyroY, &GyroZ);\r\n  if(GyroX< -1000 ||GyroX> 1000 || GyroY>1000 || GyroY< -1000 || GyroZ >1000 || GyroZ < -1000 ) {\r\n  tone(buzzer,1000);\r\n  digitalWrite(11,HIGH);\r\n  delay(1000);\r\n  } else {\r\n  noTone(buzzer);\r\n  digitalWrite(11,LOW);\r\n  }\r\n}";
        string depremDesc = "Deprem sensörü, deprem anında titreşimi algılayarak direkt ötmeye ve ledi yakmaya yarar. Çalışma mantığından biraz bahsetmek gerekirse, kullandığımız mpu6050(eksen, ivme ve gyro sensörü) sayesinde anlık olarak aldığımız verileri işleyerek, deprem esnasında ledin yanmasına ve buzzerın ötmesini sağlayacağız.";
        string depremDevreElemanlari = "Breadboard\r\nJumper Kablo \r\nYeşil Led 5mm \r\nBuzzer\r\nMPU6050\r\nArduino Uno \r\nDirenç";
    }
}