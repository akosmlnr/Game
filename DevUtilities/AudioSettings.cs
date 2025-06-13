using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000492 RID: 1170
	[System.Serializable]
	public class AudioSettings : Il2CppSystem.Object
	{
		// Token: 0x06006439 RID: 25657 RVA: 0x001C9AC0 File Offset: 0x001C7CC0
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSettings()
		{
			Il2CppClassPointerStore<AudioSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "AudioSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr);
			AudioSettings.NativeFieldInfoPtr_MasterVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "MasterVolume");
			AudioSettings.NativeFieldInfoPtr_AmbientVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "AmbientVolume");
			AudioSettings.NativeFieldInfoPtr_MusicVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "MusicVolume");
			AudioSettings.NativeFieldInfoPtr_SFXVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "SFXVolume");
			AudioSettings.NativeFieldInfoPtr_UIVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "UIVolume");
			AudioSettings.NativeFieldInfoPtr_DialogueVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "DialogueVolume");
			AudioSettings.NativeFieldInfoPtr_FootstepsVolume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, "FootstepsVolume");
			AudioSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr, 100676110);
		}

		// Token: 0x0600643A RID: 25658 RVA: 0x001C9B90 File Offset: 0x001C7D90
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSettings() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSettings>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600643B RID: 25659 RVA: 0x0002F1F3 File Offset: 0x0002D3F3
		public AudioSettings(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DEF RID: 7663
		// (get) Token: 0x0600643C RID: 25660 RVA: 0x001C9BCC File Offset: 0x001C7DCC
		// (set) Token: 0x0600643D RID: 25661 RVA: 0x0002F1FC File Offset: 0x0002D3FC
		public unsafe float MasterVolume
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MasterVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MasterVolume)) = value;
			}
		}

		// Token: 0x17001DF0 RID: 7664
		// (get) Token: 0x0600643E RID: 25662 RVA: 0x001C9BF4 File Offset: 0x001C7DF4
		// (set) Token: 0x0600643F RID: 25663 RVA: 0x0002F217 File Offset: 0x0002D417
		public unsafe float AmbientVolume
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_AmbientVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_AmbientVolume)) = value;
			}
		}

		// Token: 0x17001DF1 RID: 7665
		// (get) Token: 0x06006440 RID: 25664 RVA: 0x001C9C1C File Offset: 0x001C7E1C
		// (set) Token: 0x06006441 RID: 25665 RVA: 0x0002F232 File Offset: 0x0002D432
		public unsafe float MusicVolume
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MusicVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_MusicVolume)) = value;
			}
		}

		// Token: 0x17001DF2 RID: 7666
		// (get) Token: 0x06006442 RID: 25666 RVA: 0x001C9C44 File Offset: 0x001C7E44
		// (set) Token: 0x06006443 RID: 25667 RVA: 0x0002F24D File Offset: 0x0002D44D
		public unsafe float SFXVolume
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_SFXVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_SFXVolume)) = value;
			}
		}

		// Token: 0x17001DF3 RID: 7667
		// (get) Token: 0x06006444 RID: 25668 RVA: 0x001C9C6C File Offset: 0x001C7E6C
		// (set) Token: 0x06006445 RID: 25669 RVA: 0x0002F268 File Offset: 0x0002D468
		public unsafe float UIVolume
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_UIVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_UIVolume)) = value;
			}
		}

		// Token: 0x17001DF4 RID: 7668
		// (get) Token: 0x06006446 RID: 25670 RVA: 0x001C9C94 File Offset: 0x001C7E94
		// (set) Token: 0x06006447 RID: 25671 RVA: 0x0002F283 File Offset: 0x0002D483
		public unsafe float DialogueVolume
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_DialogueVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_DialogueVolume)) = value;
			}
		}

		// Token: 0x17001DF5 RID: 7669
		// (get) Token: 0x06006448 RID: 25672 RVA: 0x001C9CBC File Offset: 0x001C7EBC
		// (set) Token: 0x06006449 RID: 25673 RVA: 0x0002F29E File Offset: 0x0002D49E
		public unsafe float FootstepsVolume
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_FootstepsVolume);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSettings.NativeFieldInfoPtr_FootstepsVolume)) = value;
			}
		}

		// Token: 0x04004458 RID: 17496
		private static readonly System.IntPtr NativeFieldInfoPtr_MasterVolume;

		// Token: 0x04004459 RID: 17497
		private static readonly System.IntPtr NativeFieldInfoPtr_AmbientVolume;

		// Token: 0x0400445A RID: 17498
		private static readonly System.IntPtr NativeFieldInfoPtr_MusicVolume;

		// Token: 0x0400445B RID: 17499
		private static readonly System.IntPtr NativeFieldInfoPtr_SFXVolume;

		// Token: 0x0400445C RID: 17500
		private static readonly System.IntPtr NativeFieldInfoPtr_UIVolume;

		// Token: 0x0400445D RID: 17501
		private static readonly System.IntPtr NativeFieldInfoPtr_DialogueVolume;

		// Token: 0x0400445E RID: 17502
		private static readonly System.IntPtr NativeFieldInfoPtr_FootstepsVolume;

		// Token: 0x0400445F RID: 17503
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
