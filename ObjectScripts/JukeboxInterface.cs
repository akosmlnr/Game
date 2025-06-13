using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000758 RID: 1880
	public class JukeboxInterface : MonoBehaviour
	{
		// Token: 0x0600AA05 RID: 43525 RVA: 0x002AA0A4 File Offset: 0x002A82A4
		// Note: this type is marked as 'beforefieldinit'.
		static JukeboxInterface()
		{
			Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "JukeboxInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr);
			JukeboxInterface.NativeFieldInfoPtr_OPEN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "OPEN_TIME");
			JukeboxInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			JukeboxInterface.NativeFieldInfoPtr_Jukebox = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "Jukebox");
			JukeboxInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "Canvas");
			JukeboxInterface.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "CameraPosition");
			JukeboxInterface.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "IntObj");
			JukeboxInterface.NativeFieldInfoPtr_PausePlayImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "PausePlayImage");
			JukeboxInterface.NativeFieldInfoPtr_ShuffleButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "ShuffleButton");
			JukeboxInterface.NativeFieldInfoPtr_RepeatButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "RepeatButton");
			JukeboxInterface.NativeFieldInfoPtr_SyncButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "SyncButton");
			JukeboxInterface.NativeFieldInfoPtr_EntryContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "EntryContainer");
			JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "AmbientDisplayContainer");
			JukeboxInterface.NativeFieldInfoPtr_AmbientDisplaySongLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "AmbientDisplaySongLabel");
			JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayTimeLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "AmbientDisplayTimeLabel");
			JukeboxInterface.NativeFieldInfoPtr_PlaySprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "PlaySprite");
			JukeboxInterface.NativeFieldInfoPtr_PauseSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "PauseSprite");
			JukeboxInterface.NativeFieldInfoPtr_SongEntryPlaySprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "SongEntryPlaySprite");
			JukeboxInterface.NativeFieldInfoPtr_SongEntryPauseSprite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "SongEntryPauseSprite");
			JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_None = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "RepeatModeSprite_None");
			JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Track = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "RepeatModeSprite_Track");
			JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Queue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "RepeatModeSprite_Queue");
			JukeboxInterface.NativeFieldInfoPtr_DeselectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "DeselectedColor");
			JukeboxInterface.NativeFieldInfoPtr_SelectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "SelectedColor");
			JukeboxInterface.NativeFieldInfoPtr_SongEntryPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "SongEntryPrefab");
			JukeboxInterface.NativeFieldInfoPtr_songEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "songEntries");
			JukeboxInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684222);
			JukeboxInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684223);
			JukeboxInterface.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684224);
			JukeboxInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684225);
			JukeboxInterface.NativeMethodInfoPtr_UpdateAmbientDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684226);
			JukeboxInterface.NativeMethodInfoPtr_SetupSongEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684227);
			JukeboxInterface.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684228);
			JukeboxInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684229);
			JukeboxInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684230);
			JukeboxInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684231);
			JukeboxInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684232);
			JukeboxInterface.NativeMethodInfoPtr_Hovered_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684233);
			JukeboxInterface.NativeMethodInfoPtr_Interacted_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684234);
			JukeboxInterface.NativeMethodInfoPtr_PlayPausePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684235);
			JukeboxInterface.NativeMethodInfoPtr_BackPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684236);
			JukeboxInterface.NativeMethodInfoPtr_NextPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684237);
			JukeboxInterface.NativeMethodInfoPtr_ShufflePressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684238);
			JukeboxInterface.NativeMethodInfoPtr_RepeatPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684239);
			JukeboxInterface.NativeMethodInfoPtr_SyncPressed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684240);
			JukeboxInterface.NativeMethodInfoPtr_SongEntryClicked_Public_Void_RectTransform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684241);
			JukeboxInterface.NativeMethodInfoPtr_RefreshSongEntries_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684242);
			JukeboxInterface.NativeMethodInfoPtr_RefreshUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684243);
			JukeboxInterface.NativeMethodInfoPtr_RefreshAmbientDisplay_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684244);
			JukeboxInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, 100684245);
		}

		// Token: 0x1700345C RID: 13404
		// (get) Token: 0x0600AA06 RID: 43526 RVA: 0x002AA4A8 File Offset: 0x002A86A8
		// (set) Token: 0x0600AA07 RID: 43527 RVA: 0x002AA4E4 File Offset: 0x002A86E4
		public unsafe bool IsOpen
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600AA08 RID: 43528 RVA: 0x002AA524 File Offset: 0x002A8724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296188, XrefRangeEnd = 296229, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA09 RID: 43529 RVA: 0x002AA558 File Offset: 0x002A8758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296229, XrefRangeEnd = 296230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA0A RID: 43530 RVA: 0x002AA58C File Offset: 0x002A878C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 296274, RefRangeEnd = 296277, XrefRangeStart = 296230, XrefRangeEnd = 296274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAmbientDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_UpdateAmbientDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA0B RID: 43531 RVA: 0x002AA5C0 File Offset: 0x002A87C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296327, RefRangeEnd = 296328, XrefRangeStart = 296277, XrefRangeEnd = 296327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupSongEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_SetupSongEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA0C RID: 43532 RVA: 0x002AA5F4 File Offset: 0x002A87F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296328, XrefRangeEnd = 296352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA0D RID: 43533 RVA: 0x002AA628 File Offset: 0x002A8828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296352, XrefRangeEnd = 296362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA0E RID: 43534 RVA: 0x002AA65C File Offset: 0x002A885C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296362, XrefRangeEnd = 296364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA0F RID: 43535 RVA: 0x002AA6A0 File Offset: 0x002A88A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296409, RefRangeEnd = 296410, XrefRangeStart = 296364, XrefRangeEnd = 296409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA10 RID: 43536 RVA: 0x002AA6D4 File Offset: 0x002A88D4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296445, RefRangeEnd = 296446, XrefRangeStart = 296410, XrefRangeEnd = 296445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA11 RID: 43537 RVA: 0x002AA708 File Offset: 0x002A8908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296446, XrefRangeEnd = 296447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Hovered_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA12 RID: 43538 RVA: 0x002AA73C File Offset: 0x002A893C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296447, XrefRangeEnd = 296448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_Interacted_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA13 RID: 43539 RVA: 0x002AA770 File Offset: 0x002A8970
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296448, XrefRangeEnd = 296450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayPausePressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_PlayPausePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA14 RID: 43540 RVA: 0x002AA7A4 File Offset: 0x002A89A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296450, XrefRangeEnd = 296454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BackPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_BackPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA15 RID: 43541 RVA: 0x002AA7D8 File Offset: 0x002A89D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296454, XrefRangeEnd = 296456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NextPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_NextPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA16 RID: 43542 RVA: 0x002AA80C File Offset: 0x002A8A0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296456, XrefRangeEnd = 296458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShufflePressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_ShufflePressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA17 RID: 43543 RVA: 0x002AA840 File Offset: 0x002A8A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296458, XrefRangeEnd = 296461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RepeatPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_RepeatPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA18 RID: 43544 RVA: 0x002AA874 File Offset: 0x002A8A74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296461, XrefRangeEnd = 296464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SyncPressed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_SyncPressed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA19 RID: 43545 RVA: 0x002AA8A8 File Offset: 0x002A8AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296464, XrefRangeEnd = 296472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SongEntryClicked(RectTransform entry)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(entry);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_SongEntryClicked_Public_Void_RectTransform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA1A RID: 43546 RVA: 0x002AA8EC File Offset: 0x002A8AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296492, RefRangeEnd = 296493, XrefRangeStart = 296472, XrefRangeEnd = 296492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshSongEntries()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_RefreshSongEntries_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA1B RID: 43547 RVA: 0x002AA920 File Offset: 0x002A8B20
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296501, RefRangeEnd = 296503, XrefRangeStart = 296493, XrefRangeEnd = 296501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_RefreshUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA1C RID: 43548 RVA: 0x002AA954 File Offset: 0x002A8B54
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296508, RefRangeEnd = 296509, XrefRangeStart = 296503, XrefRangeEnd = 296508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshAmbientDisplay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr_RefreshAmbientDisplay_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA1D RID: 43549 RVA: 0x002AA988 File Offset: 0x002A8B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296509, XrefRangeEnd = 296517, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JukeboxInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600AA1E RID: 43550 RVA: 0x00053813 File Offset: 0x00051A13
		public JukeboxInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003443 RID: 13379
		// (get) Token: 0x0600AA1F RID: 43551 RVA: 0x002AA9C4 File Offset: 0x002A8BC4
		// (set) Token: 0x0600AA20 RID: 43552 RVA: 0x0005381C File Offset: 0x00051A1C
		public unsafe static float OPEN_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(JukeboxInterface.NativeFieldInfoPtr_OPEN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(JukeboxInterface.NativeFieldInfoPtr_OPEN_TIME, (void*)(&value));
			}
		}

		// Token: 0x17003444 RID: 13380
		// (get) Token: 0x0600AA21 RID: 43553 RVA: 0x002AA9E0 File Offset: 0x002A8BE0
		// (set) Token: 0x0600AA22 RID: 43554 RVA: 0x0005382A File Offset: 0x00051A2A
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17003445 RID: 13381
		// (get) Token: 0x0600AA23 RID: 43555 RVA: 0x002AAA08 File Offset: 0x002A8C08
		// (set) Token: 0x0600AA24 RID: 43556 RVA: 0x00053845 File Offset: 0x00051A45
		public unsafe Jukebox Jukebox
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_Jukebox);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jukebox>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_Jukebox), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003446 RID: 13382
		// (get) Token: 0x0600AA25 RID: 43557 RVA: 0x002AAA38 File Offset: 0x002A8C38
		// (set) Token: 0x0600AA26 RID: 43558 RVA: 0x00053864 File Offset: 0x00051A64
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0600AA27 RID: 43559 RVA: 0x002AAA68 File Offset: 0x002A8C68
		// (set) Token: 0x0600AA28 RID: 43560 RVA: 0x00053883 File Offset: 0x00051A83
		public unsafe Transform CameraPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_CameraPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0600AA29 RID: 43561 RVA: 0x002AAA98 File Offset: 0x002A8C98
		// (set) Token: 0x0600AA2A RID: 43562 RVA: 0x000538A2 File Offset: 0x00051AA2
		public unsafe InteractableObject IntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_IntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0600AA2B RID: 43563 RVA: 0x002AAAC8 File Offset: 0x002A8CC8
		// (set) Token: 0x0600AA2C RID: 43564 RVA: 0x000538C1 File Offset: 0x00051AC1
		public unsafe Image PausePlayImage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PausePlayImage);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PausePlayImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0600AA2D RID: 43565 RVA: 0x002AAAF8 File Offset: 0x002A8CF8
		// (set) Token: 0x0600AA2E RID: 43566 RVA: 0x000538E0 File Offset: 0x00051AE0
		public unsafe Button ShuffleButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_ShuffleButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_ShuffleButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0600AA2F RID: 43567 RVA: 0x002AAB28 File Offset: 0x002A8D28
		// (set) Token: 0x0600AA30 RID: 43568 RVA: 0x000538FF File Offset: 0x00051AFF
		public unsafe Button RepeatButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700344C RID: 13388
		// (get) Token: 0x0600AA31 RID: 43569 RVA: 0x002AAB58 File Offset: 0x002A8D58
		// (set) Token: 0x0600AA32 RID: 43570 RVA: 0x0005391E File Offset: 0x00051B1E
		public unsafe Button SyncButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SyncButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SyncButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700344D RID: 13389
		// (get) Token: 0x0600AA33 RID: 43571 RVA: 0x002AAB88 File Offset: 0x002A8D88
		// (set) Token: 0x0600AA34 RID: 43572 RVA: 0x0005393D File Offset: 0x00051B3D
		public unsafe RectTransform EntryContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_EntryContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_EntryContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700344E RID: 13390
		// (get) Token: 0x0600AA35 RID: 43573 RVA: 0x002AABB8 File Offset: 0x002A8DB8
		// (set) Token: 0x0600AA36 RID: 43574 RVA: 0x0005395C File Offset: 0x00051B5C
		public unsafe GameObject AmbientDisplayContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700344F RID: 13391
		// (get) Token: 0x0600AA37 RID: 43575 RVA: 0x002AABE8 File Offset: 0x002A8DE8
		// (set) Token: 0x0600AA38 RID: 43576 RVA: 0x0005397B File Offset: 0x00051B7B
		public unsafe TextMeshPro AmbientDisplaySongLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplaySongLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplaySongLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003450 RID: 13392
		// (get) Token: 0x0600AA39 RID: 43577 RVA: 0x002AAC18 File Offset: 0x002A8E18
		// (set) Token: 0x0600AA3A RID: 43578 RVA: 0x0005399A File Offset: 0x00051B9A
		public unsafe TextMeshPro AmbientDisplayTimeLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayTimeLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_AmbientDisplayTimeLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003451 RID: 13393
		// (get) Token: 0x0600AA3B RID: 43579 RVA: 0x002AAC48 File Offset: 0x002A8E48
		// (set) Token: 0x0600AA3C RID: 43580 RVA: 0x000539B9 File Offset: 0x00051BB9
		public unsafe Sprite PlaySprite
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PlaySprite);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PlaySprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003452 RID: 13394
		// (get) Token: 0x0600AA3D RID: 43581 RVA: 0x002AAC78 File Offset: 0x002A8E78
		// (set) Token: 0x0600AA3E RID: 43582 RVA: 0x000539D8 File Offset: 0x00051BD8
		public unsafe Sprite PauseSprite
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PauseSprite);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_PauseSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003453 RID: 13395
		// (get) Token: 0x0600AA3F RID: 43583 RVA: 0x002AACA8 File Offset: 0x002A8EA8
		// (set) Token: 0x0600AA40 RID: 43584 RVA: 0x000539F7 File Offset: 0x00051BF7
		public unsafe Sprite SongEntryPlaySprite
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPlaySprite);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPlaySprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003454 RID: 13396
		// (get) Token: 0x0600AA41 RID: 43585 RVA: 0x002AACD8 File Offset: 0x002A8ED8
		// (set) Token: 0x0600AA42 RID: 43586 RVA: 0x00053A16 File Offset: 0x00051C16
		public unsafe Sprite SongEntryPauseSprite
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPauseSprite);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPauseSprite), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003455 RID: 13397
		// (get) Token: 0x0600AA43 RID: 43587 RVA: 0x002AAD08 File Offset: 0x002A8F08
		// (set) Token: 0x0600AA44 RID: 43588 RVA: 0x00053A35 File Offset: 0x00051C35
		public unsafe Sprite RepeatModeSprite_None
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_None);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_None), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003456 RID: 13398
		// (get) Token: 0x0600AA45 RID: 43589 RVA: 0x002AAD38 File Offset: 0x002A8F38
		// (set) Token: 0x0600AA46 RID: 43590 RVA: 0x00053A54 File Offset: 0x00051C54
		public unsafe Sprite RepeatModeSprite_Track
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Track);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Track), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x0600AA47 RID: 43591 RVA: 0x002AAD68 File Offset: 0x002A8F68
		// (set) Token: 0x0600AA48 RID: 43592 RVA: 0x00053A73 File Offset: 0x00051C73
		public unsafe Sprite RepeatModeSprite_Queue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Queue);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_RepeatModeSprite_Queue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x0600AA49 RID: 43593 RVA: 0x002AAD98 File Offset: 0x002A8F98
		// (set) Token: 0x0600AA4A RID: 43594 RVA: 0x00053A92 File Offset: 0x00051C92
		public unsafe Color DeselectedColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_DeselectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_DeselectedColor)) = value;
			}
		}

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x0600AA4B RID: 43595 RVA: 0x002AADC0 File Offset: 0x002A8FC0
		// (set) Token: 0x0600AA4C RID: 43596 RVA: 0x00053AAD File Offset: 0x00051CAD
		public unsafe Color SelectedColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SelectedColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SelectedColor)) = value;
			}
		}

		// Token: 0x1700345A RID: 13402
		// (get) Token: 0x0600AA4D RID: 43597 RVA: 0x002AADE8 File Offset: 0x002A8FE8
		// (set) Token: 0x0600AA4E RID: 43598 RVA: 0x00053AC8 File Offset: 0x00051CC8
		public unsafe GameObject SongEntryPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_SongEntryPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700345B RID: 13403
		// (get) Token: 0x0600AA4F RID: 43599 RVA: 0x002AAE18 File Offset: 0x002A9018
		// (set) Token: 0x0600AA50 RID: 43600 RVA: 0x00053AE7 File Offset: 0x00051CE7
		public unsafe List<RectTransform> songEntries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_songEntries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.NativeFieldInfoPtr_songEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007216 RID: 29206
		private static readonly System.IntPtr NativeFieldInfoPtr_OPEN_TIME;

		// Token: 0x04007217 RID: 29207
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x04007218 RID: 29208
		private static readonly System.IntPtr NativeFieldInfoPtr_Jukebox;

		// Token: 0x04007219 RID: 29209
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400721A RID: 29210
		private static readonly System.IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x0400721B RID: 29211
		private static readonly System.IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x0400721C RID: 29212
		private static readonly System.IntPtr NativeFieldInfoPtr_PausePlayImage;

		// Token: 0x0400721D RID: 29213
		private static readonly System.IntPtr NativeFieldInfoPtr_ShuffleButton;

		// Token: 0x0400721E RID: 29214
		private static readonly System.IntPtr NativeFieldInfoPtr_RepeatButton;

		// Token: 0x0400721F RID: 29215
		private static readonly System.IntPtr NativeFieldInfoPtr_SyncButton;

		// Token: 0x04007220 RID: 29216
		private static readonly System.IntPtr NativeFieldInfoPtr_EntryContainer;

		// Token: 0x04007221 RID: 29217
		private static readonly System.IntPtr NativeFieldInfoPtr_AmbientDisplayContainer;

		// Token: 0x04007222 RID: 29218
		private static readonly System.IntPtr NativeFieldInfoPtr_AmbientDisplaySongLabel;

		// Token: 0x04007223 RID: 29219
		private static readonly System.IntPtr NativeFieldInfoPtr_AmbientDisplayTimeLabel;

		// Token: 0x04007224 RID: 29220
		private static readonly System.IntPtr NativeFieldInfoPtr_PlaySprite;

		// Token: 0x04007225 RID: 29221
		private static readonly System.IntPtr NativeFieldInfoPtr_PauseSprite;

		// Token: 0x04007226 RID: 29222
		private static readonly System.IntPtr NativeFieldInfoPtr_SongEntryPlaySprite;

		// Token: 0x04007227 RID: 29223
		private static readonly System.IntPtr NativeFieldInfoPtr_SongEntryPauseSprite;

		// Token: 0x04007228 RID: 29224
		private static readonly System.IntPtr NativeFieldInfoPtr_RepeatModeSprite_None;

		// Token: 0x04007229 RID: 29225
		private static readonly System.IntPtr NativeFieldInfoPtr_RepeatModeSprite_Track;

		// Token: 0x0400722A RID: 29226
		private static readonly System.IntPtr NativeFieldInfoPtr_RepeatModeSprite_Queue;

		// Token: 0x0400722B RID: 29227
		private static readonly System.IntPtr NativeFieldInfoPtr_DeselectedColor;

		// Token: 0x0400722C RID: 29228
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectedColor;

		// Token: 0x0400722D RID: 29229
		private static readonly System.IntPtr NativeFieldInfoPtr_SongEntryPrefab;

		// Token: 0x0400722E RID: 29230
		private static readonly System.IntPtr NativeFieldInfoPtr_songEntries;

		// Token: 0x0400722F RID: 29231
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x04007230 RID: 29232
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Private_set_Void_Boolean_0;

		// Token: 0x04007231 RID: 29233
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04007232 RID: 29234
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04007233 RID: 29235
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateAmbientDisplay_Private_Void_0;

		// Token: 0x04007234 RID: 29236
		private static readonly System.IntPtr NativeMethodInfoPtr_SetupSongEntries_Private_Void_0;

		// Token: 0x04007235 RID: 29237
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04007236 RID: 29238
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04007237 RID: 29239
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x04007238 RID: 29240
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04007239 RID: 29241
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x0400723A RID: 29242
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Private_Void_0;

		// Token: 0x0400723B RID: 29243
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Private_Void_0;

		// Token: 0x0400723C RID: 29244
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayPausePressed_Public_Void_0;

		// Token: 0x0400723D RID: 29245
		private static readonly System.IntPtr NativeMethodInfoPtr_BackPressed_Public_Void_0;

		// Token: 0x0400723E RID: 29246
		private static readonly System.IntPtr NativeMethodInfoPtr_NextPressed_Public_Void_0;

		// Token: 0x0400723F RID: 29247
		private static readonly System.IntPtr NativeMethodInfoPtr_ShufflePressed_Public_Void_0;

		// Token: 0x04007240 RID: 29248
		private static readonly System.IntPtr NativeMethodInfoPtr_RepeatPressed_Public_Void_0;

		// Token: 0x04007241 RID: 29249
		private static readonly System.IntPtr NativeMethodInfoPtr_SyncPressed_Public_Void_0;

		// Token: 0x04007242 RID: 29250
		private static readonly System.IntPtr NativeMethodInfoPtr_SongEntryClicked_Public_Void_RectTransform_0;

		// Token: 0x04007243 RID: 29251
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshSongEntries_Private_Void_0;

		// Token: 0x04007244 RID: 29252
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshUI_Private_Void_0;

		// Token: 0x04007245 RID: 29253
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshAmbientDisplay_Private_Void_0;

		// Token: 0x04007246 RID: 29254
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C2D RID: 3117
		[ObfuscatedName("ScheduleOne.ObjectScripts.JukeboxInterface+<>c__DisplayClass31_0")]
		public sealed class __c__DisplayClass31_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E418 RID: 58392 RVA: 0x0035EBE0 File Offset: 0x0035CDE0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass31_0()
			{
				Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass31_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<JukeboxInterface>.NativeClassPtr, "<>c__DisplayClass31_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass31_0>.NativeClassPtr);
				JukeboxInterface.__c__DisplayClass31_0.NativeFieldInfoPtr_entry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass31_0>.NativeClassPtr, "entry");
				JukeboxInterface.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass31_0>.NativeClassPtr, "<>4__this");
				JukeboxInterface.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass31_0>.NativeClassPtr, 100684246);
				JukeboxInterface.__c__DisplayClass31_0.NativeMethodInfoPtr__SetupSongEntries_b__0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass31_0>.NativeClassPtr, 100684247);
			}

			// Token: 0x0600E419 RID: 58393 RVA: 0x0035EC5C File Offset: 0x0035CE5C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass31_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JukeboxInterface.__c__DisplayClass31_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.__c__DisplayClass31_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E41A RID: 58394 RVA: 0x0035EC98 File Offset: 0x0035CE98
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296170, XrefRangeEnd = 296188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _SetupSongEntries_b__0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JukeboxInterface.__c__DisplayClass31_0.NativeMethodInfoPtr__SetupSongEntries_b__0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E41B RID: 58395 RVA: 0x0006EE81 File Offset: 0x0006D081
			public __c__DisplayClass31_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004666 RID: 18022
			// (get) Token: 0x0600E41C RID: 58396 RVA: 0x0035ECCC File Offset: 0x0035CECC
			// (set) Token: 0x0600E41D RID: 58397 RVA: 0x0006EE8A File Offset: 0x0006D08A
			public unsafe GameObject entry
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.__c__DisplayClass31_0.NativeFieldInfoPtr_entry);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.__c__DisplayClass31_0.NativeFieldInfoPtr_entry), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004667 RID: 18023
			// (get) Token: 0x0600E41E RID: 58398 RVA: 0x0035ECFC File Offset: 0x0035CEFC
			// (set) Token: 0x0600E41F RID: 58399 RVA: 0x0006EEA9 File Offset: 0x0006D0A9
			public unsafe JukeboxInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<JukeboxInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(JukeboxInterface.__c__DisplayClass31_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040098C4 RID: 39108
			private static readonly System.IntPtr NativeFieldInfoPtr_entry;

			// Token: 0x040098C5 RID: 39109
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040098C6 RID: 39110
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040098C7 RID: 39111
			private static readonly System.IntPtr NativeMethodInfoPtr__SetupSongEntries_b__0_Internal_Void_0;
		}
	}
}
