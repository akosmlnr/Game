using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Audio
{
	// Token: 0x020004F1 RID: 1265
	public class AudioZoneModifierVolume : MonoBehaviour
	{
		// Token: 0x06006DDB RID: 28123 RVA: 0x001EA680 File Offset: 0x001E8880
		// Note: this type is marked as 'beforefieldinit'.
		static AudioZoneModifierVolume()
		{
			Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Audio", "AudioZoneModifierVolume");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr);
			AudioZoneModifierVolume.NativeFieldInfoPtr_Zones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "Zones");
			AudioZoneModifierVolume.NativeFieldInfoPtr_VolumeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "VolumeMultiplier");
			AudioZoneModifierVolume.NativeFieldInfoPtr_colliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, "colliders");
			AudioZoneModifierVolume.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100677276);
			AudioZoneModifierVolume.NativeMethodInfoPtr_Refresh_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100677277);
			AudioZoneModifierVolume.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr, 100677278);
		}

		// Token: 0x06006DDC RID: 28124 RVA: 0x001EA728 File Offset: 0x001E8928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220563, XrefRangeEnd = 220575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DDD RID: 28125 RVA: 0x001EA75C File Offset: 0x001E895C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220575, XrefRangeEnd = 220619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Refresh()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr_Refresh_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DDE RID: 28126 RVA: 0x001EA790 File Offset: 0x001E8990
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 220619, XrefRangeEnd = 220627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioZoneModifierVolume() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioZoneModifierVolume>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioZoneModifierVolume.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006DDF RID: 28127 RVA: 0x00033BFA File Offset: 0x00031DFA
		public AudioZoneModifierVolume(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170020D6 RID: 8406
		// (get) Token: 0x06006DE0 RID: 28128 RVA: 0x001EA7CC File Offset: 0x001E89CC
		// (set) Token: 0x06006DE1 RID: 28129 RVA: 0x00033C03 File Offset: 0x00031E03
		public unsafe List<AudioZone> Zones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_Zones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AudioZone>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_Zones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170020D7 RID: 8407
		// (get) Token: 0x06006DE2 RID: 28130 RVA: 0x001EA7FC File Offset: 0x001E89FC
		// (set) Token: 0x06006DE3 RID: 28131 RVA: 0x00033C22 File Offset: 0x00031E22
		public unsafe float VolumeMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_VolumeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_VolumeMultiplier)) = value;
			}
		}

		// Token: 0x170020D8 RID: 8408
		// (get) Token: 0x06006DE4 RID: 28132 RVA: 0x001EA824 File Offset: 0x001E8A24
		// (set) Token: 0x06006DE5 RID: 28133 RVA: 0x00033C3D File Offset: 0x00031E3D
		public unsafe Il2CppReferenceArray<BoxCollider> colliders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_colliders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioZoneModifierVolume.NativeFieldInfoPtr_colliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004B29 RID: 19241
		private static readonly IntPtr NativeFieldInfoPtr_Zones;

		// Token: 0x04004B2A RID: 19242
		private static readonly IntPtr NativeFieldInfoPtr_VolumeMultiplier;

		// Token: 0x04004B2B RID: 19243
		private static readonly IntPtr NativeFieldInfoPtr_colliders;

		// Token: 0x04004B2C RID: 19244
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04004B2D RID: 19245
		private static readonly IntPtr NativeMethodInfoPtr_Refresh_Private_Void_0;

		// Token: 0x04004B2E RID: 19246
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
