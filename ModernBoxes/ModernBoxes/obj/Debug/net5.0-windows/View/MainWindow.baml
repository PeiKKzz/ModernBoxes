   M S B A M L   `   `   `  ����  ModernBoxes    ModernBoxes.MainWindow   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OHandyControl, Version=3.2.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5          �Name$  window��5	       � Title$ 
MainWindow��5
      $
��1400��5      $
��1000��5       � AllowsTransparency$
 True��5      
������  � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $2 ,/Resource/dictionary/MainWindowResource.xaml?�6%   %    5      .��5      7  1HandyControl.Controls.TransitioningContentControl  .��5   
   �� ._�5      � 	 � ColumnDefinitions	 5      �� 5      $
��auto �6'   �� 5       $
��auto �6'   �� 5"      $
��auto �6'   .+�5&      � $��1��6   .+�5(         HandyControl.Controls.Card  -   5        $��MiddleWindow��5)      )  #HandyControl.Controls.BorderElement
   CornerRadius$
 8��5+         RegionBrush#���   5,        EffectShadow1 J� Effect# [ 5-      ��5*      ��  �� ElementName$ Toggle�� �� Path$ 	IsChecked�  	toconvert �� 	Converter# [ .��5.      �  � RowDefinitions 5/      �� 50   "   �� 51   "   $
��auto �60   .+�53      ��  �� Orientation$ Vertical=�6)   .+�54   "   d� -   5        $��Toggle��55   %   $��40��56   %   $��0,16,0,0q�57   %   $	��Top=�58   %     MainMenuToggleButton#���  59   %    � ContextMenu 5:   &   �� 5;   *   .@�5<   .   m� $��层级��67   .@�5=   2   m� -   5        $��topItem��5>   5   $��顶层��5@   5    m� IsCheckable$
 True��5A   5    m� 	IsChecked$ False��5B   5   m� 5C   2   -   5        $��
BottomItem��5D   5   $��底层��5F   5   $
 True��5G   5   $
 True��5H   5   5I   /   m� 5J   .   -   5        $��	btn_fixed��5K   1   $��固定��5M   1   $ False��5N   1   m� 5O   .   -   5        $��	btn_close��5P   1   $��关闭��5R   1   5S   +   5U   #   (  "HandyControl.Controls.ScrollViewer  5W   "      Orientation$ Vertical=�62   .��5Y   &   �� -   5        $��items��5Y   3   ��6@   �� *
MenuList+��5Z   *   �� 5[   .   .R�5\   2   �� $ Vertical=�6=   5]   /   ��5`   *   �� 5a   .   .R�5b   2   �� $��0,6,0,0q�6=   $ 
Horizontal=�6N   .+�5e   6   	� $	��200��5f   9   $��Center=�5g   9   $��Center=�5h   9    	� 	GroupName$
 menu��5l   9     	MenuStyle#��[ 5m   9   ��5i   9   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType ItemsControl$ DataContext.OpenApp���5j   9   �� *Target+��5k   9   �� *
MenuName+ � ToolTip 5n   9   �� *
MenuName+ 5o   6   �� 5p   :   .@�5q   >   m� $��
AddCardApp��5r   A   -	   5        $��添加卡片应用��5t   A   y�5u   A   �� *
MenuName+  IsShowContextMenu# [ m� 5v   >   $��BtnDeleteMenuItem��5w   A   -
   5        $��删除��5z   A    m� CommandParameter 5y   A   �� *
MenuName+5z   A   5{   ;   5}   3   5~   /   5�   '   5�   #   �� 5�   "   $��	0,10,0,10q�5�   %   $��Center=�5�   %   $��/Resource/#iconfont)�5�   %   $��25(�5�   %   
�������$ 添加��5�   %   ��5�   %   �� *AddMenuDialog+��5�   &   �� 5�   *   .R�5�   .   �� $	����68    �� Triggers 5�   .   P� 5�   2    P� Property �@J�IsMouseOver P� Value$
 True��6Q   . �5�   6   ��  �� Property �@J�Opacity �� Value$ .9Q�6P   5�   3   P� 5�   2    � {�$ False��6O   . �5�   6   ��  �@J�Opacity$	 0.4Q�6P   5�   3   5�   +   5�   #   5�      �� 5�      $��1��6)   .+�5�   "   �� -   5        $��btnConfigMenu��5�   %   $��8q�5�   %   $��Center=�5�   %   $��/Resource/#iconfont)�5�   %   $��20(�5�   %   
�������  BtnConfigMenuStyle#���  5�   %   ��5�   %   �� *OpenSetDialog+5�   %   5�      5�      5�      5�        5�      -   5        $��compontentLayoutLeft��5�      $��0��5�      $	��440��5�      $��
10,0,10,10q�5�      $y�Hidden=�5�      .��5�      �� -   5          ��Name$  LeftContent��5�   %   5�        5�      -   5        $��compontentLayoutRight��5�      $��2��5�      $	��440��5�      $��
10,0,10,10q�5�      $y�Hidden=�5�      .��5�      �� -   5        $  RightContent��5�   %   5�      &   HandyControl.Controls.NotifyIcon  5�      -   5        !  Name$! NotifyIconContextContent��5�      "   Icon$" /Resource/logo.ico��5�      #   Text$# 木函��5�      $y�Visible=�5�       5�      �� 5�      .@�5�      m� $��Center=�5�   !   $��Center=�5�   !   $ m� Command$$$ hc:ControlCommands.ShutdownApp��5�   !   $��/Resource/#iconfont)�5�   !   $��退出程序��5�   !   % m� Icon$	% ��5�   !   5�      ,  &HandyControl.Interactivity.Interaction&   Triggers& 5�      -  'HandyControl.Interactivity.EventTrigger  5�      '   	EventName$' Click��6*   ,  &HandyControl.Interactivity.TriggerBase(   Actions.( 5�      /	  )HandyControl.Interactivity.EventToCommand	  ) 	  Command$+) %hc:ControlCommands.PushMainWindow2Top��60   5�      5�      5�      5�      5�      5�      