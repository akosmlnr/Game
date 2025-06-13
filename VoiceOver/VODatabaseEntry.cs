using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x0200017B RID: 379
	[System.Serializable]
	public class VODatabaseEntry : Il2CppSystem.Object
	{
		// Token: 0x06001E0C RID: 7692 RVA: 0x000D0E14 File Offset: 0x000CF014
		// Note: this type is marked as 'beforefieldinit'.
		static VODatabaseEntry()
		{
			Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "VODatabaseEntry");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr);
			VODatabaseEntry.NativeFieldInfoPtr_LineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "LineType");
			VODatabaseEntry.NativeFieldInfoPtr_Clips = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "Clips");
			VODatabaseEntry.NativeFieldInfoPtr_lastClip = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "lastClip");
			VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, "VolumeMultiplier");
			VODatabaseEntry.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, 100666754);
			VODatabaseEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr, 100666755);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x000D0EBC File Offset: 0x000CF0BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109775, XrefRangeEnd = 109783, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetRandomClip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabaseEntry.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x000D0EFC File Offset: 0x000CF0FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109783, XrefRangeEnd = 109784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabaseEntry() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VODatabaseEntry>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabaseEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x00010DB9 File Offset: 0x0000EFB9
		public VODatabaseEntry(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x000D0F38 File Offset: 0x000CF138
		// (set) Token: 0x06001E11 RID: 7697 RVA: 0x00010DC2 File Offset: 0x0000EFC2
		public unsafe EVOLineType LineType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_LineType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_LineType)) = value;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x000D0F60 File Offset: 0x000CF160
		// (set) Token: 0x06001E13 RID: 7699 RVA: 0x00010DDD File Offset: 0x0000EFDD
		public unsafe Il2CppReferenceArray<AudioClip> Clips
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_Clips);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<AudioClip>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_Clips), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x000D0F90 File Offset: 0x000CF190
		// (set) Token: 0x06001E15 RID: 7701 RVA: 0x00010DFC File Offset: 0x0000EFFC
		public unsafe AudioClip lastClip
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_lastClip);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_lastClip), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06001E16 RID: 7702 RVA: 0x000D0FC0 File Offset: 0x000CF1C0
		// (set) Token: 0x06001E17 RID: 7703 RVA: 0x00010E1B File Offset: 0x0000F01B
		public unsafe float VolumeMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabaseEntry.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x04001401 RID: 5121
		private static readonly System.IntPtr NativeFieldInfoPtr_LineType;

		// Token: 0x04001402 RID: 5122
		private static readonly System.IntPtr NativeFieldInfoPtr_Clips;

		// Token: 0x04001403 RID: 5123
		private static readonly System.IntPtr NativeFieldInfoPtr_lastClip;

		// Token: 0x04001404 RID: 5124
		private static readonly System.IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04001405 RID: 5125
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_0;

		// Token: 0x04001406 RID: 5126
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
