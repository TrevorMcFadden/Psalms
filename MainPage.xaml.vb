Imports Windows.Media.Core
Imports Windows.Storage
Imports Windows.Storage.Pickers
Imports Windows.System

Public NotInheritable Class MainPage
    Inherits Page
    Private Async Sub PsalmsAddSong_Click(sender As Object, e As RoutedEventArgs) Handles PsalmsAddSong.Click
        Dim MediaContent As FileOpenPicker = New FileOpenPicker()
        MediaContent.ViewMode = PickerViewMode.List
        MediaContent.SuggestedStartLocation = PickerLocationId.MusicLibrary
        MediaContent.FileTypeFilter.Add(".wmv")
        MediaContent.FileTypeFilter.Add(".wma")
        MediaContent.FileTypeFilter.Add(".mp3")
        MediaContent.FileTypeFilter.Add(".mp4")
        Dim openmedia As StorageFile = Await MediaContent.PickSingleFileAsync()
        PsalmsMediaPlayer.AutoPlay = True
        PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromStorageFile(openmedia))
        PsalmsNowPlayingPivotItem.Header = "Now playing: " & openmedia.DisplayName.ToString()
        PsalmsMediaPlayer.Play()
        If openmedia Is Nothing Then
            Dim errorDialog As ContentDialog = New ContentDialog() With {
                .Title = "Open File Error",
                .Content = "The selected file is unable to be opened.",
                .CloseButtonText = "Ok"
            }
            Await errorDialog.ShowAsync()
        End If
    End Sub
    Private Sub PsalmsPlay_Click(sender As Object, e As RoutedEventArgs) Handles PsalmsPlay.Click
        If PsalmsSongBox.SelectedIndex = 0 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/All.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: All"
        End If
        If PsalmsSongBox.SelectedIndex = 1 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Community.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Community"
        End If
        If PsalmsSongBox.SelectedIndex = 2 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Connection.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Connection"
        End If
        If PsalmsSongBox.SelectedIndex = 3 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Day Well Spent.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Day Well Spent"
        End If
        If PsalmsSongBox.SelectedIndex = 4 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Day.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Day"
        End If
        If PsalmsSongBox.SelectedIndex = 5 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Flux.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Flux"
        End If
        If PsalmsSongBox.SelectedIndex = 6 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Healing.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Healing"
        End If
        If PsalmsSongBox.SelectedIndex = 7 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Hybrid.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Hybrid"
        End If
        If PsalmsSongBox.SelectedIndex = 8 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Nova.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Nova"
        End If
        If PsalmsSongBox.SelectedIndex = 9 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Overdrive.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Overdrive"
        End If
        If PsalmsSongBox.SelectedIndex = 10 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Peace.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Peace"
        End If
        If PsalmsSongBox.SelectedIndex = 11 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Process.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Process"
        End If
        If PsalmsSongBox.SelectedIndex = 12 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Purify.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Purify"
        End If
        If PsalmsSongBox.SelectedIndex = 13 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Slow.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Slow"
        End If
        If PsalmsSongBox.SelectedIndex = 14 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Sprinkle.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Sprinkle"
        End If
        If PsalmsSongBox.SelectedIndex = 15 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Sub.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Sub"
        End If
        If PsalmsSongBox.SelectedIndex = 16 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Time.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Time"
        End If
        If PsalmsSongBox.SelectedIndex = 17 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Travels.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Travels"
        End If
        If PsalmsSongBox.SelectedIndex = 18 Then
            PsalmsMediaPlayer.SetPlaybackSource(MediaSource.CreateFromUri(New Uri("ms-appx:///Songs/Vibes.mp3")))
            PsalmsNowPlayingPivotItem.Header = "Now playing: Vibes"
        End If
    End Sub
    Private Async Sub Me_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs) Handles Me.Loaded
        Dim u As IReadOnlyList(Of User) = Await User.FindAllAsync()
        Dim current = u.Where(Function(p) p.AuthenticationStatus = UserAuthenticationStatus.LocallyAuthenticated AndAlso p.Type = UserType.LocalUser).FirstOrDefault()
        Dim data = Await current.GetPropertyAsync(KnownUserProperties.FirstName)
        Dim em = Await current.GetPropertyAsync(KnownUserProperties.AccountName)
        Dim displayName As String = CStr(data)
        Dim displayEmail As String = CStr(em)
        UserNameBlock.Text = "Hello " & displayName
    End Sub
End Class