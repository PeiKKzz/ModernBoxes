   M S B A M L   `   `   `  ����F  BModernBoxes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullY1clr-namespace:ModernBoxes.View.SelfControl.dialog#ModernBoxes.View.SelfControl.dialog  5      :    4ModernBoxes.View.SelfControl.dialog.AddTempDirDialog   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      S OHandyControl, Version=3.2.0.0, Culture=neutral, PublicKeyToken=45be8712787a1e5b0hc'https://handyorg.github.io/handycontrol  5      =local1clr-namespace:ModernBoxes.View.SelfControl.dialog  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      $��10q�5	         RegionBrush#���   5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $: 4\Resource\dictionary\AddTempDirDialogDictionary.xaml?�6%   %    5      .��5      7  1HandyControl.Controls.TransitioningContentControl  $��10q�6%   .��5   
   �� .+�5      �  � ColumnDefinitions 5      �� 5      �� 5      $
��auto �6'   .+�5      �� -   5         ��Name$ 
TB_DirPath��5      $��0��5      $��5,0,5,0q�5      $��Center=�5       '  !HandyControl.Controls.InfoElement   	Necessary$
 True��5!         Placeholder$ 文件夹路径��5"      (  "HandyControl.Controls.TitleElement   TitlePlacement$
 Left=�5#        TextBoxExtend#��[ 5$      ��5%      �� *DirModel.TempDirPath+ �� Mode$ TwoWay=��� 5&      -   5        	 ��Name$	 btn_ChooseDirPath��5'      $��1��5(      $��5,0,5,0q�5)      $��Center=�5*      $��选择��5,        ButtonPrimary#���  5-      ��5+      �� *
ChoseDir+5-      5.      �� 5/      -   5        $��SP_isRef��50      $��
10,10,10,0q�51      
 �� Orientation$
 
Horizontal=�52      .+�53      �� $��Center=�6   $��是否引用��67   d� 54      -   5         d�Name$ 	TB_DirRef��55      $��26,0,0,0q�56      $��Center=�57       d� 	IsChecked$
 TrueY�58        ToggleButtonSwitch#��[ 59      �� 5:      $��30,0,0,0q�5;      $��Center=�5<      $��/Resource/#iconfont)�5=      $��18(�5>      
�������$	����5@      *  $HandyControl.Controls.AdornerElement   Instance 5A      "  HandyControl.Controls.Poptip  5B         Content$� ~引用：就是使用文件夹的路径，不引用就会将此文件夹复制到缓存中并使用缓存中的文件夹内容��6$      PlacementType$ Right=�6Y   5D      5E      �� 5F      $��10q�6   $
 
Horizontal=�6%   .+�5G      �� $��0,0,10,0q�5H      $��Center=�5I      $��文件夹类型��5J      	� 5K      -   5         	�Name$	 red��5L        RadioButtonStyle1#��[ 5N       5M      �� *
DirKind[0]+5N      	� 5O      -   5        $��yellow��5P        RadioButtonStyle2#��[ 5R       5Q      �� *
DirKind[1]+5R      	� 5S      -   5        $
 blue��5T        RadioButtonStyle3#��[ 5V       5U      �� *
DirKind[2]+5V      	� 5W      -   5        $ green��5X        RadioButtonStyle4#��[ 5Z       5Y      �� *
DirKind[3]+5Z      5[      �� 5\      $��Center=�5]      $��确定��5`      #���  5a      ��5^      �� *
AddTempDir+��5_      ��  �� ElementName$ 	TB_DirRef��5a      5b      5c      5d      