   M S B A M L   `   `   `  ����E  AMailClient, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MailClient
MailClient  5          MailClient.SendMessage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:MailClient     5        N� Title$  SendMessage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��54* �6   �� 5      $	��54* �6   �� 5      $	��54* �6   �� 5      $
��197* �6   �� 5      $	��57* �6   .+�5   
   �� $��От кого: ��6   $
��Left=�6$   $��Center=�6?   $��Center=�6c   $��Center=�6�   $��54��6�   $	��132��6�   $��18(�6�   �� 5   
   $��
Кому: ��6   $
��Left=�6!   $��Center=�6<   $��Center=�6`   $	��Top=�6�   $��54��6�   $	��132��6�   $��18(�6�   $��1��6�   �� 5   
   $��
Тема: ��6   $
��Left=�6!   $��Center=�6<   $��Center=�6`   $	��Top=�6�   $��54��6�   $	��132��6�   $��18(�6�   $��2��6�   �� 5   
   $%��Текст сообщения: ��6   $��Center=�6,   $��Center=�6I   $��Center=�6m   $	��Top=�6�   $��54��6�   $	��800��6�   $��18(�6�   $��2��6�   $��0,58,0,0q�6�   $��2��6�   �� 5   
   -   5        $��SendMessageButton��5      $��Отправить��6*   $��Center=�6>   $��4��6[   $��Center=�6h   $��62��6�   $	��800��6�   6�   �� 5   
   -   5        $��from_textBox��5      $
��Left=�6&   $��	137,2,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��663��6�   $��51��6�   �� 5   
   -   5        $��
to_textBox��5      $
��Left=�6$   $��
137,58,0,0q�6?   $
 Wrap=�6S   $	��Top=�6g   $	��663��6   $��54��6�   $��2��6�   �� 5   
   -   5        $��subject_textBox��5      $
��Left=�6)   $��	137,0,0,0q�6D   $��2��6W   $
 Wrap=�6d   $	��Top=�6x   $	��663��6�   $��54��6�   �� 5   
   -   5        $��messageText_textBox��5      $��Center=�6-   $��0,59,0,0q�6J   $��3��6\   $
 Wrap=�6i   $	��Top=�6}   $	��800��6�   $	��149��6�   5      5      