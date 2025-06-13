using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x02000757 RID: 1879
	public class Jukebox : GridItem
	{
		// Token: 0x0600A9C2 RID: 43458 RVA: 0x002A8DC4 File Offset: 0x002A6FC4
		// Note: this type is marked as 'beforefieldinit'.
		static Jukebox()
		{
			Il2CppClassPointerStore<Jukebox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "Jukebox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jukebox>.NativeClassPtr);
			Jukebox.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "MUSIC_FADE_MULTIPLIER");
			Jukebox.NativeFieldInfoPtr_TRACK_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "TRACK_COUNT");
			Jukebox.NativeFieldInfoPtr__jukeboxState = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "_jukeboxState");
			Jukebox.NativeFieldInfoPtr_TrackList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "TrackList");
			Jukebox.NativeFieldInfoPtr_VolumeIndicatorBars = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "VolumeIndicatorBars");
			Jukebox.NativeFieldInfoPtr_AudioSourceController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "AudioSourceController");
			Jukebox.NativeFieldInfoPtr_onStateChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "onStateChanged");
			Jukebox.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.ObjectScripts.JukeboxAssembly-CSharp.dll_Excuted");
			Jukebox.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.ObjectScripts.JukeboxAssembly-CSharp.dll_Excuted");
			Jukebox.NativeMethodInfoPtr_get_CurrentVolume_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684173);
			Jukebox.NativeMethodInfoPtr_get_NormalizedVolume_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684174);
			Jukebox.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684175);
			Jukebox.NativeMethodInfoPtr_get_CurrentTrackTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684176);
			Jukebox.NativeMethodInfoPtr_get_TrackOrder_Private_get_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684177);
			Jukebox.NativeMethodInfoPtr_get_CurrentTrackOrderIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684178);
			Jukebox.NativeMethodInfoPtr_get_Shuffle_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684179);
			Jukebox.NativeMethodInfoPtr_get_RepeatMode_Public_get_ERepeatMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684180);
			Jukebox.NativeMethodInfoPtr_get_Sync_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684181);
			Jukebox.NativeMethodInfoPtr_get_currentTrack_Public_get_Track_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684182);
			Jukebox.NativeMethodInfoPtr_get_currentClip_Private_get_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684183);
			Jukebox.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684184);
			Jukebox.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684185);
			Jukebox.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684186);
			Jukebox.NativeMethodInfoPtr_ChangeVolume_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684187);
			Jukebox.NativeMethodInfoPtr_SetVolume_Public_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684188);
			Jukebox.NativeMethodInfoPtr_ApplyVolume_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684189);
			Jukebox.NativeMethodInfoPtr_TogglePlay_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684190);
			Jukebox.NativeMethodInfoPtr_Back_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684191);
			Jukebox.NativeMethodInfoPtr_Next_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684192);
			Jukebox.NativeMethodInfoPtr_GetPreviousTrackOrderIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684193);
			Jukebox.NativeMethodInfoPtr_GetNextTrackOrderIndex_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684194);
			Jukebox.NativeMethodInfoPtr_ToggleShuffle_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684195);
			Jukebox.NativeMethodInfoPtr_ToggleRepeatMode_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684196);
			Jukebox.NativeMethodInfoPtr_ToggleSync_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684197);
			Jukebox.NativeMethodInfoPtr_PlayTrack_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684198);
			Jukebox.NativeMethodInfoPtr_SendJukeboxState_Public_Void_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684199);
			Jukebox.NativeMethodInfoPtr_SetJukeboxState_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684200);
			Jukebox.NativeMethodInfoPtr_SetJukeboxState_Public_Void_JukeboxState_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684201);
			Jukebox.NativeMethodInfoPtr_GetTrack_Private_Track_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684202);
			Jukebox.NativeMethodInfoPtr_ValidateQueue_Private_Boolean_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684203);
			Jukebox.NativeMethodInfoPtr_ReplicateStateToOtherClients_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684204);
			Jukebox.NativeMethodInfoPtr_ReplicateStateToOtherJukeboxes_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684205);
			Jukebox.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684206);
			Jukebox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684207);
			Jukebox.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684208);
			Jukebox.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684209);
			Jukebox.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684210);
			Jukebox.NativeMethodInfoPtr_RpcWriter___Server_SendJukeboxState_1728100027_Private_Void_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684211);
			Jukebox.NativeMethodInfoPtr_RpcLogic___SendJukeboxState_1728100027_Public_Void_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684212);
			Jukebox.NativeMethodInfoPtr_RpcReader___Server_SendJukeboxState_1728100027_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684213);
			Jukebox.NativeMethodInfoPtr_RpcWriter___Observers_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684214);
			Jukebox.NativeMethodInfoPtr_RpcLogic___SetJukeboxState_2499833112_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684215);
			Jukebox.NativeMethodInfoPtr_RpcReader___Observers_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684216);
			Jukebox.NativeMethodInfoPtr_RpcWriter___Target_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684217);
			Jukebox.NativeMethodInfoPtr_RpcReader___Target_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684218);
			Jukebox.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, 100684219);
		}

		// Token: 0x17003438 RID: 13368
		// (get) Token: 0x0600A9C3 RID: 43459 RVA: 0x002A9254 File Offset: 0x002A7454
		public unsafe int CurrentVolume
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295740, RefRangeEnd = 295741, XrefRangeStart = 295740, XrefRangeEnd = 295740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_CurrentVolume_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17003439 RID: 13369
		// (get) Token: 0x0600A9C4 RID: 43460 RVA: 0x002A9290 File Offset: 0x002A7490
		public unsafe float NormalizedVolume
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_NormalizedVolume_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700343A RID: 13370
		// (get) Token: 0x0600A9C5 RID: 43461 RVA: 0x002A92CC File Offset: 0x002A74CC
		public unsafe bool IsPlaying
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295741, RefRangeEnd = 295742, XrefRangeStart = 295741, XrefRangeEnd = 295741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0600A9C6 RID: 43462 RVA: 0x002A9308 File Offset: 0x002A7508
		public unsafe float CurrentTrackTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_CurrentTrackTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0600A9C7 RID: 43463 RVA: 0x002A9344 File Offset: 0x002A7544
		public unsafe Il2CppStructArray<int> TrackOrder
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_TrackOrder_Private_get_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0600A9C8 RID: 43464 RVA: 0x002A9384 File Offset: 0x002A7584
		public unsafe int CurrentTrackOrderIndex
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_CurrentTrackOrderIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700343E RID: 13374
		// (get) Token: 0x0600A9C9 RID: 43465 RVA: 0x002A93C0 File Offset: 0x002A75C0
		public unsafe bool Shuffle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_Shuffle_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700343F RID: 13375
		// (get) Token: 0x0600A9CA RID: 43466 RVA: 0x002A93FC File Offset: 0x002A75FC
		public unsafe Jukebox.ERepeatMode RepeatMode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_RepeatMode_Public_get_ERepeatMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17003440 RID: 13376
		// (get) Token: 0x0600A9CB RID: 43467 RVA: 0x002A9438 File Offset: 0x002A7638
		public unsafe bool Sync
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_Sync_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17003441 RID: 13377
		// (get) Token: 0x0600A9CC RID: 43468 RVA: 0x002A9474 File Offset: 0x002A7674
		public unsafe Jukebox.Track currentTrack
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295742, XrefRangeEnd = 295744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_currentTrack_Public_get_Track_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jukebox.Track>(intPtr2) : null;
			}
		}

		// Token: 0x17003442 RID: 13378
		// (get) Token: 0x0600A9CD RID: 43469 RVA: 0x002A94B4 File Offset: 0x002A76B4
		public unsafe AudioClip currentClip
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295744, XrefRangeEnd = 295745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_get_currentClip_Private_get_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
		}

		// Token: 0x0600A9CE RID: 43470 RVA: 0x002A94F4 File Offset: 0x002A76F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295745, XrefRangeEnd = 295746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9CF RID: 43471 RVA: 0x002A9530 File Offset: 0x002A7730
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295746, XrefRangeEnd = 295750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9D0 RID: 43472 RVA: 0x002A9564 File Offset: 0x002A7764
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295750, XrefRangeEnd = 295753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9D1 RID: 43473 RVA: 0x002A95B4 File Offset: 0x002A77B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295753, XrefRangeEnd = 295755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeVolume(int change)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref change;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ChangeVolume_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9D2 RID: 43474 RVA: 0x002A95F4 File Offset: 0x002A77F4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295760, RefRangeEnd = 295763, XrefRangeStart = 295755, XrefRangeEnd = 295760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVolume(int volume, bool replicate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref volume;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref replicate;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_SetVolume_Public_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9D3 RID: 43475 RVA: 0x002A9640 File Offset: 0x002A7840
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295770, RefRangeEnd = 295772, XrefRangeStart = 295763, XrefRangeEnd = 295770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyVolume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ApplyVolume_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x002A9674 File Offset: 0x002A7874
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 295775, RefRangeEnd = 295778, XrefRangeStart = 295772, XrefRangeEnd = 295775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void TogglePlay()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_TogglePlay_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x002A96A8 File Offset: 0x002A78A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295778, XrefRangeEnd = 295782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Back()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_Back_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9D6 RID: 43478 RVA: 0x002A96DC File Offset: 0x002A78DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295785, RefRangeEnd = 295786, XrefRangeStart = 295782, XrefRangeEnd = 295785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Next()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_Next_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9D7 RID: 43479 RVA: 0x002A9710 File Offset: 0x002A7910
		[CallerCount(0)]
		public unsafe int GetPreviousTrackOrderIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_GetPreviousTrackOrderIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x002A974C File Offset: 0x002A794C
		[CallerCount(0)]
		public unsafe int GetNextTrackOrderIndex()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_GetNextTrackOrderIndex_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x002A9788 File Offset: 0x002A7988
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 295816, RefRangeEnd = 295817, XrefRangeStart = 295786, XrefRangeEnd = 295816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleShuffle()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ToggleShuffle_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x002A97BC File Offset: 0x002A79BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295817, XrefRangeEnd = 295820, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleRepeatMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ToggleRepeatMode_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9DB RID: 43483 RVA: 0x002A97F0 File Offset: 0x002A79F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295820, XrefRangeEnd = 295823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ToggleSync()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ToggleSync_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x002A9824 File Offset: 0x002A7A24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 295854, RefRangeEnd = 295856, XrefRangeStart = 295823, XrefRangeEnd = 295854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayTrack(int trackID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref trackID;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_PlayTrack_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x002A9864 File Offset: 0x002A7A64
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 295879, RefRangeEnd = 295892, XrefRangeStart = 295856, XrefRangeEnd = 295879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendJukeboxState(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setSync;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_SendJukeboxState_Public_Void_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x002A98C4 File Offset: 0x002A7AC4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 295938, RefRangeEnd = 295944, XrefRangeStart = 295892, XrefRangeEnd = 295938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetJukeboxState(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setSync;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_SetJukeboxState_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x002A9934 File Offset: 0x002A7B34
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 295996, RefRangeEnd = 296000, XrefRangeStart = 295944, XrefRangeEnd = 295996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetJukeboxState(Jukebox.JukeboxState state, bool setTrackTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setTrackTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_SetJukeboxState_Public_Void_JukeboxState_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x002A9984 File Offset: 0x002A7B84
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 296003, RefRangeEnd = 296012, XrefRangeStart = 296000, XrefRangeEnd = 296003, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Jukebox.Track GetTrack(int orderIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref orderIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_GetTrack_Private_Track_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jukebox.Track>(intPtr2) : null;
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x002A99D0 File Offset: 0x002A7BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296012, XrefRangeEnd = 296033, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool ValidateQueue(Il2CppStructArray<int> queue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(queue);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ValidateQueue_Private_Boolean_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600A9E2 RID: 43490 RVA: 0x002A9A20 File Offset: 0x002A7C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296033, XrefRangeEnd = 296034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateStateToOtherClients(bool setTrackTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref setTrackTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ReplicateStateToOtherClients_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9E3 RID: 43491 RVA: 0x002A9A60 File Offset: 0x002A7C60
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 296056, RefRangeEnd = 296066, XrefRangeStart = 296034, XrefRangeEnd = 296056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateStateToOtherJukeboxes(bool setTrackTime)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref setTrackTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_ReplicateStateToOtherJukeboxes_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9E4 RID: 43492 RVA: 0x002A9AA0 File Offset: 0x002A7CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296066, XrefRangeEnd = 296070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override BuildableItemData GetBaseData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItemData>(intPtr2) : null;
		}

		// Token: 0x0600A9E5 RID: 43493 RVA: 0x002A9AEC File Offset: 0x002A7CEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Jukebox() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jukebox>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x002A9B28 File Offset: 0x002A7D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296070, XrefRangeEnd = 296091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x002A9B64 File Offset: 0x002A7D64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296091, XrefRangeEnd = 296092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9E8 RID: 43496 RVA: 0x002A9BA0 File Offset: 0x002A7DA0
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 184680, RefRangeEnd = 184686, XrefRangeStart = 184680, XrefRangeEnd = 184686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9E9 RID: 43497 RVA: 0x002A9BDC File Offset: 0x002A7DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296092, XrefRangeEnd = 296104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendJukeboxState_1728100027(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setSync;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcWriter___Server_SendJukeboxState_1728100027_Private_Void_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9EA RID: 43498 RVA: 0x002A9C3C File Offset: 0x002A7E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296104, XrefRangeEnd = 296105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendJukeboxState_1728100027(Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setSync;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcLogic___SendJukeboxState_1728100027_Public_Void_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9EB RID: 43499 RVA: 0x002A9C9C File Offset: 0x002A7E9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296105, XrefRangeEnd = 296109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendJukeboxState_1728100027(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcReader___Server_SendJukeboxState_1728100027_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x002A9D00 File Offset: 0x002A7F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296109, XrefRangeEnd = 296121, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setSync;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcWriter___Observers_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9ED RID: 43501 RVA: 0x002A9D70 File Offset: 0x002A7F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296121, XrefRangeEnd = 296122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setSync;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcLogic___SetJukeboxState_2499833112_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x002A9DE0 File Offset: 0x002A7FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296122, XrefRangeEnd = 296126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetJukeboxState_2499833112(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcReader___Observers_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x002A9E30 File Offset: 0x002A8030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296126, XrefRangeEnd = 296138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetJukeboxState_2499833112(NetworkConnection conn, Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setTrackTime;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref setSync;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcWriter___Target_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x002A9EA0 File Offset: 0x002A80A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 296138, XrefRangeEnd = 296142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetJukeboxState_2499833112(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.NativeMethodInfoPtr_RpcReader___Target_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9F1 RID: 43505 RVA: 0x002A9EF0 File Offset: 0x002A80F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 296169, RefRangeEnd = 296170, XrefRangeStart = 296142, XrefRangeEnd = 296169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Method_Protected_Virtual_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Jukebox.NativeMethodInfoPtr_Method_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A9F2 RID: 43506 RVA: 0x0005371D File Offset: 0x0005191D
		public Jukebox(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700342F RID: 13359
		// (get) Token: 0x0600A9F3 RID: 43507 RVA: 0x002A9F2C File Offset: 0x002A812C
		// (set) Token: 0x0600A9F4 RID: 43508 RVA: 0x00053726 File Offset: 0x00051926
		public unsafe static float MUSIC_FADE_MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Jukebox.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Jukebox.NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17003430 RID: 13360
		// (get) Token: 0x0600A9F5 RID: 43509 RVA: 0x002A9F48 File Offset: 0x002A8148
		// (set) Token: 0x0600A9F6 RID: 43510 RVA: 0x00053734 File Offset: 0x00051934
		public unsafe static int TRACK_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Jukebox.NativeFieldInfoPtr_TRACK_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Jukebox.NativeFieldInfoPtr_TRACK_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17003431 RID: 13361
		// (get) Token: 0x0600A9F7 RID: 43511 RVA: 0x002A9F64 File Offset: 0x002A8164
		// (set) Token: 0x0600A9F8 RID: 43512 RVA: 0x00053742 File Offset: 0x00051942
		public unsafe Jukebox.JukeboxState _jukeboxState
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr__jukeboxState);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Jukebox.JukeboxState>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr__jukeboxState), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003432 RID: 13362
		// (get) Token: 0x0600A9F9 RID: 43513 RVA: 0x002A9F94 File Offset: 0x002A8194
		// (set) Token: 0x0600A9FA RID: 43514 RVA: 0x00053761 File Offset: 0x00051961
		public unsafe Il2CppReferenceArray<Jukebox.Track> TrackList
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_TrackList);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Jukebox.Track>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_TrackList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003433 RID: 13363
		// (get) Token: 0x0600A9FB RID: 43515 RVA: 0x002A9FC4 File Offset: 0x002A81C4
		// (set) Token: 0x0600A9FC RID: 43516 RVA: 0x00053780 File Offset: 0x00051980
		public unsafe Il2CppReferenceArray<GameObject> VolumeIndicatorBars
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_VolumeIndicatorBars);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_VolumeIndicatorBars), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003434 RID: 13364
		// (get) Token: 0x0600A9FD RID: 43517 RVA: 0x002A9FF4 File Offset: 0x002A81F4
		// (set) Token: 0x0600A9FE RID: 43518 RVA: 0x0005379F File Offset: 0x0005199F
		public unsafe AudioSourceController AudioSourceController
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_AudioSourceController);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_AudioSourceController), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003435 RID: 13365
		// (get) Token: 0x0600A9FF RID: 43519 RVA: 0x002AA024 File Offset: 0x002A8224
		// (set) Token: 0x0600AA00 RID: 43520 RVA: 0x000537BE File Offset: 0x000519BE
		public unsafe Il2CppSystem.Action onStateChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_onStateChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_onStateChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003436 RID: 13366
		// (get) Token: 0x0600AA01 RID: 43521 RVA: 0x002AA054 File Offset: 0x002A8254
		// (set) Token: 0x0600AA02 RID: 43522 RVA: 0x000537DD File Offset: 0x000519DD
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17003437 RID: 13367
		// (get) Token: 0x0600AA03 RID: 43523 RVA: 0x002AA07C File Offset: 0x002A827C
		// (set) Token: 0x0600AA04 RID: 43524 RVA: 0x000537F8 File Offset: 0x000519F8
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040071DE RID: 29150
		private static readonly System.IntPtr NativeFieldInfoPtr_MUSIC_FADE_MULTIPLIER;

		// Token: 0x040071DF RID: 29151
		private static readonly System.IntPtr NativeFieldInfoPtr_TRACK_COUNT;

		// Token: 0x040071E0 RID: 29152
		private static readonly System.IntPtr NativeFieldInfoPtr__jukeboxState;

		// Token: 0x040071E1 RID: 29153
		private static readonly System.IntPtr NativeFieldInfoPtr_TrackList;

		// Token: 0x040071E2 RID: 29154
		private static readonly System.IntPtr NativeFieldInfoPtr_VolumeIndicatorBars;

		// Token: 0x040071E3 RID: 29155
		private static readonly System.IntPtr NativeFieldInfoPtr_AudioSourceController;

		// Token: 0x040071E4 RID: 29156
		private static readonly System.IntPtr NativeFieldInfoPtr_onStateChanged;

		// Token: 0x040071E5 RID: 29157
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040071E6 RID: 29158
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040071E7 RID: 29159
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentVolume_Public_get_Int32_0;

		// Token: 0x040071E8 RID: 29160
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NormalizedVolume_Public_get_Single_0;

		// Token: 0x040071E9 RID: 29161
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x040071EA RID: 29162
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentTrackTime_Public_get_Single_0;

		// Token: 0x040071EB RID: 29163
		private static readonly System.IntPtr NativeMethodInfoPtr_get_TrackOrder_Private_get_Il2CppStructArray_1_Int32_0;

		// Token: 0x040071EC RID: 29164
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentTrackOrderIndex_Public_get_Int32_0;

		// Token: 0x040071ED RID: 29165
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Shuffle_Public_get_Boolean_0;

		// Token: 0x040071EE RID: 29166
		private static readonly System.IntPtr NativeMethodInfoPtr_get_RepeatMode_Public_get_ERepeatMode_0;

		// Token: 0x040071EF RID: 29167
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Sync_Public_get_Boolean_0;

		// Token: 0x040071F0 RID: 29168
		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentTrack_Public_get_Track_0;

		// Token: 0x040071F1 RID: 29169
		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentClip_Private_get_AudioClip_0;

		// Token: 0x040071F2 RID: 29170
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x040071F3 RID: 29171
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040071F4 RID: 29172
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x040071F5 RID: 29173
		private static readonly System.IntPtr NativeMethodInfoPtr_ChangeVolume_Public_Void_Int32_0;

		// Token: 0x040071F6 RID: 29174
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVolume_Public_Void_Int32_Boolean_0;

		// Token: 0x040071F7 RID: 29175
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyVolume_Private_Void_0;

		// Token: 0x040071F8 RID: 29176
		private static readonly System.IntPtr NativeMethodInfoPtr_TogglePlay_Public_Void_0;

		// Token: 0x040071F9 RID: 29177
		private static readonly System.IntPtr NativeMethodInfoPtr_Back_Public_Void_0;

		// Token: 0x040071FA RID: 29178
		private static readonly System.IntPtr NativeMethodInfoPtr_Next_Public_Void_0;

		// Token: 0x040071FB RID: 29179
		private static readonly System.IntPtr NativeMethodInfoPtr_GetPreviousTrackOrderIndex_Private_Int32_0;

		// Token: 0x040071FC RID: 29180
		private static readonly System.IntPtr NativeMethodInfoPtr_GetNextTrackOrderIndex_Private_Int32_0;

		// Token: 0x040071FD RID: 29181
		private static readonly System.IntPtr NativeMethodInfoPtr_ToggleShuffle_Public_Void_0;

		// Token: 0x040071FE RID: 29182
		private static readonly System.IntPtr NativeMethodInfoPtr_ToggleRepeatMode_Public_Void_0;

		// Token: 0x040071FF RID: 29183
		private static readonly System.IntPtr NativeMethodInfoPtr_ToggleSync_Public_Void_0;

		// Token: 0x04007200 RID: 29184
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayTrack_Public_Void_Int32_0;

		// Token: 0x04007201 RID: 29185
		private static readonly System.IntPtr NativeMethodInfoPtr_SendJukeboxState_Public_Void_JukeboxState_Boolean_Boolean_0;

		// Token: 0x04007202 RID: 29186
		private static readonly System.IntPtr NativeMethodInfoPtr_SetJukeboxState_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0;

		// Token: 0x04007203 RID: 29187
		private static readonly System.IntPtr NativeMethodInfoPtr_SetJukeboxState_Public_Void_JukeboxState_Boolean_0;

		// Token: 0x04007204 RID: 29188
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTrack_Private_Track_Int32_0;

		// Token: 0x04007205 RID: 29189
		private static readonly System.IntPtr NativeMethodInfoPtr_ValidateQueue_Private_Boolean_Il2CppStructArray_1_Int32_0;

		// Token: 0x04007206 RID: 29190
		private static readonly System.IntPtr NativeMethodInfoPtr_ReplicateStateToOtherClients_Private_Void_Boolean_0;

		// Token: 0x04007207 RID: 29191
		private static readonly System.IntPtr NativeMethodInfoPtr_ReplicateStateToOtherJukeboxes_Private_Void_Boolean_0;

		// Token: 0x04007208 RID: 29192
		private static readonly System.IntPtr NativeMethodInfoPtr_GetBaseData_Public_Virtual_BuildableItemData_0;

		// Token: 0x04007209 RID: 29193
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400720A RID: 29194
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x0400720B RID: 29195
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x0400720C RID: 29196
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400720D RID: 29197
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendJukeboxState_1728100027_Private_Void_JukeboxState_Boolean_Boolean_0;

		// Token: 0x0400720E RID: 29198
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendJukeboxState_1728100027_Public_Void_JukeboxState_Boolean_Boolean_0;

		// Token: 0x0400720F RID: 29199
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendJukeboxState_1728100027_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04007210 RID: 29200
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0;

		// Token: 0x04007211 RID: 29201
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetJukeboxState_2499833112_Public_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0;

		// Token: 0x04007212 RID: 29202
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007213 RID: 29203
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetJukeboxState_2499833112_Private_Void_NetworkConnection_JukeboxState_Boolean_Boolean_0;

		// Token: 0x04007214 RID: 29204
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetJukeboxState_2499833112_Private_Void_PooledReader_Channel_0;

		// Token: 0x04007215 RID: 29205
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Protected_Virtual_Void_0;

		// Token: 0x02000C2A RID: 3114
		[System.Serializable]
		public class Track : Il2CppSystem.Object
		{
			// Token: 0x0600E3FC RID: 58364 RVA: 0x0035E844 File Offset: 0x0035CA44
			// Note: this type is marked as 'beforefieldinit'.
			static Track()
			{
				Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "Track");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr);
				Jukebox.Track.NativeFieldInfoPtr_TrackName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr, "TrackName");
				Jukebox.Track.NativeFieldInfoPtr_Clip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr, "Clip");
				Jukebox.Track.NativeFieldInfoPtr_ArtistName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr, "ArtistName");
				Jukebox.Track.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr, 100684220);
			}

			// Token: 0x0600E3FD RID: 58365 RVA: 0x0035E8C0 File Offset: 0x0035CAC0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 295733, XrefRangeEnd = 295738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Track() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jukebox.Track>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.Track.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E3FE RID: 58366 RVA: 0x0006ED36 File Offset: 0x0006CF36
			public Track(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700465B RID: 18011
			// (get) Token: 0x0600E3FF RID: 58367 RVA: 0x0035E8FC File Offset: 0x0035CAFC
			// (set) Token: 0x0600E400 RID: 58368 RVA: 0x0006ED3F File Offset: 0x0006CF3F
			public unsafe string TrackName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_TrackName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_TrackName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700465C RID: 18012
			// (get) Token: 0x0600E401 RID: 58369 RVA: 0x0035E924 File Offset: 0x0035CB24
			// (set) Token: 0x0600E402 RID: 58370 RVA: 0x0006ED5E File Offset: 0x0006CF5E
			public unsafe AudioClip Clip
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_Clip);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_Clip), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700465D RID: 18013
			// (get) Token: 0x0600E403 RID: 58371 RVA: 0x0035E954 File Offset: 0x0035CB54
			// (set) Token: 0x0600E404 RID: 58372 RVA: 0x0006ED7D File Offset: 0x0006CF7D
			public unsafe string ArtistName
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_ArtistName);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.Track.NativeFieldInfoPtr_ArtistName), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040098B3 RID: 39091
			private static readonly System.IntPtr NativeFieldInfoPtr_TrackName;

			// Token: 0x040098B4 RID: 39092
			private static readonly System.IntPtr NativeFieldInfoPtr_Clip;

			// Token: 0x040098B5 RID: 39093
			private static readonly System.IntPtr NativeFieldInfoPtr_ArtistName;

			// Token: 0x040098B6 RID: 39094
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000C2B RID: 3115
		[System.Serializable]
		public class JukeboxState : Il2CppSystem.Object
		{
			// Token: 0x0600E405 RID: 58373 RVA: 0x0035E97C File Offset: 0x0035CB7C
			// Note: this type is marked as 'beforefieldinit'.
			static JukeboxState()
			{
				Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Jukebox>.NativeClassPtr, "JukeboxState");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr);
				Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "CurrentVolume");
				Jukebox.JukeboxState.NativeFieldInfoPtr_IsPlaying = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "IsPlaying");
				Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "CurrentTrackTime");
				Jukebox.JukeboxState.NativeFieldInfoPtr_TrackOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "TrackOrder");
				Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackOrderIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "CurrentTrackOrderIndex");
				Jukebox.JukeboxState.NativeFieldInfoPtr_Shuffle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "Shuffle");
				Jukebox.JukeboxState.NativeFieldInfoPtr_RepeatMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "RepeatMode");
				Jukebox.JukeboxState.NativeFieldInfoPtr_Sync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, "Sync");
				Jukebox.JukeboxState.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr, 100684221);
			}

			// Token: 0x0600E406 RID: 58374 RVA: 0x0035EA5C File Offset: 0x0035CC5C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 295739, RefRangeEnd = 295740, XrefRangeStart = 295738, XrefRangeEnd = 295739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe JukeboxState() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Jukebox.JukeboxState>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Jukebox.JukeboxState.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E407 RID: 58375 RVA: 0x0006ED9C File Offset: 0x0006CF9C
			public JukeboxState(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700465E RID: 18014
			// (get) Token: 0x0600E408 RID: 58376 RVA: 0x0035EA98 File Offset: 0x0035CC98
			// (set) Token: 0x0600E409 RID: 58377 RVA: 0x0006EDA5 File Offset: 0x0006CFA5
			public unsafe int CurrentVolume
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentVolume);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentVolume)) = value;
				}
			}

			// Token: 0x1700465F RID: 18015
			// (get) Token: 0x0600E40A RID: 58378 RVA: 0x0035EAC0 File Offset: 0x0035CCC0
			// (set) Token: 0x0600E40B RID: 58379 RVA: 0x0006EDC0 File Offset: 0x0006CFC0
			public unsafe bool IsPlaying
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_IsPlaying);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_IsPlaying)) = value;
				}
			}

			// Token: 0x17004660 RID: 18016
			// (get) Token: 0x0600E40C RID: 58380 RVA: 0x0035EAE8 File Offset: 0x0035CCE8
			// (set) Token: 0x0600E40D RID: 58381 RVA: 0x0006EDDB File Offset: 0x0006CFDB
			public unsafe float CurrentTrackTime
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackTime);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackTime)) = value;
				}
			}

			// Token: 0x17004661 RID: 18017
			// (get) Token: 0x0600E40E RID: 58382 RVA: 0x0035EB10 File Offset: 0x0035CD10
			// (set) Token: 0x0600E40F RID: 58383 RVA: 0x0006EDF6 File Offset: 0x0006CFF6
			public unsafe Il2CppStructArray<int> TrackOrder
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_TrackOrder);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_TrackOrder), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004662 RID: 18018
			// (get) Token: 0x0600E410 RID: 58384 RVA: 0x0035EB40 File Offset: 0x0035CD40
			// (set) Token: 0x0600E411 RID: 58385 RVA: 0x0006EE15 File Offset: 0x0006D015
			public unsafe int CurrentTrackOrderIndex
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackOrderIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_CurrentTrackOrderIndex)) = value;
				}
			}

			// Token: 0x17004663 RID: 18019
			// (get) Token: 0x0600E412 RID: 58386 RVA: 0x0035EB68 File Offset: 0x0035CD68
			// (set) Token: 0x0600E413 RID: 58387 RVA: 0x0006EE30 File Offset: 0x0006D030
			public unsafe bool Shuffle
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_Shuffle);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_Shuffle)) = value;
				}
			}

			// Token: 0x17004664 RID: 18020
			// (get) Token: 0x0600E414 RID: 58388 RVA: 0x0035EB90 File Offset: 0x0035CD90
			// (set) Token: 0x0600E415 RID: 58389 RVA: 0x0006EE4B File Offset: 0x0006D04B
			public unsafe Jukebox.ERepeatMode RepeatMode
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_RepeatMode);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_RepeatMode)) = value;
				}
			}

			// Token: 0x17004665 RID: 18021
			// (get) Token: 0x0600E416 RID: 58390 RVA: 0x0035EBB8 File Offset: 0x0035CDB8
			// (set) Token: 0x0600E417 RID: 58391 RVA: 0x0006EE66 File Offset: 0x0006D066
			public unsafe bool Sync
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_Sync);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Jukebox.JukeboxState.NativeFieldInfoPtr_Sync)) = value;
				}
			}

			// Token: 0x040098B7 RID: 39095
			private static readonly System.IntPtr NativeFieldInfoPtr_CurrentVolume;

			// Token: 0x040098B8 RID: 39096
			private static readonly System.IntPtr NativeFieldInfoPtr_IsPlaying;

			// Token: 0x040098B9 RID: 39097
			private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTrackTime;

			// Token: 0x040098BA RID: 39098
			private static readonly System.IntPtr NativeFieldInfoPtr_TrackOrder;

			// Token: 0x040098BB RID: 39099
			private static readonly System.IntPtr NativeFieldInfoPtr_CurrentTrackOrderIndex;

			// Token: 0x040098BC RID: 39100
			private static readonly System.IntPtr NativeFieldInfoPtr_Shuffle;

			// Token: 0x040098BD RID: 39101
			private static readonly System.IntPtr NativeFieldInfoPtr_RepeatMode;

			// Token: 0x040098BE RID: 39102
			private static readonly System.IntPtr NativeFieldInfoPtr_Sync;

			// Token: 0x040098BF RID: 39103
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000C2C RID: 3116
		[OriginalName("Assembly-CSharp.dll", "", "ERepeatMode")]
		public enum ERepeatMode
		{
			// Token: 0x040098C1 RID: 39105
			None,
			// Token: 0x040098C2 RID: 39106
			RepeatQueue,
			// Token: 0x040098C3 RID: 39107
			RepeatTrack
		}
	}
}
