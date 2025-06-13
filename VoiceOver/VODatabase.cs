using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.VoiceOver
{
	// Token: 0x0200017A RID: 378
	[Serializable]
	public class VODatabase : ScriptableObject
	{
		// Token: 0x06001E03 RID: 7683 RVA: 0x000D0C54 File Offset: 0x000CEE54
		// Note: this type is marked as 'beforefieldinit'.
		static VODatabase()
		{
			Il2CppClassPointerStore<VODatabase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.VoiceOver", "VODatabase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VODatabase>.NativeClassPtr);
			VODatabase.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, "VolumeMultiplier");
			VODatabase.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, "Entries");
			VODatabase.NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100666751);
			VODatabase.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100666752);
			VODatabase.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VODatabase>.NativeClassPtr, 100666753);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x000D0CE8 File Offset: 0x000CEEE8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 109763, RefRangeEnd = 109766, XrefRangeStart = 109753, XrefRangeEnd = 109763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabaseEntry GetEntry(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<VODatabaseEntry>(intPtr2) : null;
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x000D0D34 File Offset: 0x000CEF34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109766, XrefRangeEnd = 109767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioClip GetRandomClip(EVOLineType lineType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref lineType;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioClip>(intPtr2) : null;
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x000D0D80 File Offset: 0x000CEF80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109767, XrefRangeEnd = 109775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VODatabase() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VODatabase>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VODatabase.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x00010D76 File Offset: 0x0000EF76
		public VODatabase(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06001E08 RID: 7688 RVA: 0x000D0DBC File Offset: 0x000CEFBC
		// (set) Token: 0x06001E09 RID: 7689 RVA: 0x00010D7F File Offset: 0x0000EF7F
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x000D0DE4 File Offset: 0x000CEFE4
		// (set) Token: 0x06001E0B RID: 7691 RVA: 0x00010D9A File Offset: 0x0000EF9A
		public unsafe List<VODatabaseEntry> Entries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_Entries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<VODatabaseEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VODatabase.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013FC RID: 5116
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x040013FD RID: 5117
		private static readonly IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x040013FE RID: 5118
		private static readonly IntPtr NativeMethodInfoPtr_GetEntry_Public_VODatabaseEntry_EVOLineType_0;

		// Token: 0x040013FF RID: 5119
		private static readonly IntPtr NativeMethodInfoPtr_GetRandomClip_Public_AudioClip_EVOLineType_0;

		// Token: 0x04001400 RID: 5120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
