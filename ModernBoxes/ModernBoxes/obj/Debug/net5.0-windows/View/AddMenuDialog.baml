   M S B A M L   `   `   `  ����  ModernBoxes$    ModernBoxes.View.AddMenuDialog   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OHandyControl, Version=3.2.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      -   5        $��
MenuDialog��5        � Title$  AddMenuDialog��5	      $	��400��5
      $	��240��5       � AllowsTransparency$
 True��5      
������  � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5       � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $7 1/Resource/dictionary/AddMenuDialogDictionary.xaml?�6%   %    5      .��5      7  1HandyControl.Controls.TransitioningContentControl  .��5   
      HandyControl.Controls.Card  $��5q�5      )  #HandyControl.Controls.BorderElement   CornerRadius$ 8��5         EffectShadow1	 J� Effect#	 [  5      .��5      � 
 � RowDefinitions
 5       �� 5!      $
��auto �6$   �� 5"      .+�5$      �� $��16,0,0,0q�5%      $��Center=�5&      $��20(�5'      $
��Bold"�5(      $��添加��5)      �� 5+      $��40��5,      $��40��5-      $��Right=�5.      $��20(�51        
closeStyle#��[ 52      ��5/      �� *CloseDialog+��50      ��  �� ElementName$ 
MenuDialog����53      �� 54      .R�55      �� $��Center=�56   !   $��Center=�57   !   $��/Resource/#iconfont)�58   !   $	����59   !   5:      5<      �� 5=      $��1��6   $��16q�6*   .+�5>      �  � ColumnDefinitions 5?      �� 5@      �� 5A      $
��auto �6/   .+�5C      �� $��0,0,0,0q�5D      '  !HandyControl.Controls.InfoElement   	Necessary$
 True��5E      (  "HandyControl.Controls.TitleElement   Title$ 路径��5F         TitlePlacement$
 Left=�5G         
TitleWidth$ 70 �5H        TextBoxExtend#��[ 5I       � ToolTip$3 -应用,文件,文件夹的路径;组件应用��5K      ��5J      �� *Menu.Target+5K      '  !HandyControl.Controls.ButtonGroup  5L      $��1��6)      Orientation$ 
Horizontal=�69   .@�5M      �� $��1,0,0,0q�5N   !   $��文件��5P   !     ButtonPrimary#���  5Q   !   $ 选择文件��5R   !   ��5O   !   �� *ChooseFilePath+5R   !   �� 5S      $��1,0,0,0q�5T   !   $��	文件夹��5V   !   #���  5W   !   $ 选择文件夹��5X   !   ��5U   !   �� *ChooseDirPath+5X   !   5Y      5Z      �� 5[      $��0,16,0,0q�5\      $
 True��5]      $ 名称��5^      $
 Left=�5_      $ 70 �5`      #��[ 5a      $$ 给它起个名字便于区分��5c      ��5b      �� *Menu.MenuName+5c      �� 5d      $��0,20,0,0q�5e      $��Center=�5f      $��确定��5h      #��[ 5i      ��5g      �� *	AddMenu+5i      5j      5k      5l      5m      5n      