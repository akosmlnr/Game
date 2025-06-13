using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppVLB;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003DB RID: 987
	public class VolumetricLightTracker : MonoBehaviour
	{
		// Token: 0x06004BCA RID: 19402 RVA: 0x00170F64 File Offset: 0x0016F164
		// Note: this type is marked as 'beforefieldinit'.
		static VolumetricLightTracker()
		{
			Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "VolumetricLightTracker");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr);
			VolumetricLightTracker.NativeFieldInfoPtr_Override = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "Override");
			VolumetricLightTracker.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "Enabled");
			VolumetricLightTracker.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "light");
			VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "optimizedLight");
			VolumetricLightTracker.NativeFieldInfoPtr_beam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "beam");
			VolumetricLightTracker.NativeFieldInfoPtr_dust = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, "dust");
			VolumetricLightTracker.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100672769);
			VolumetricLightTracker.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100672770);
			VolumetricLightTracker.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr, 100672771);
		}

		// Token: 0x06004BCB RID: 19403 RVA: 0x00171048 File Offset: 0x0016F248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168470, XrefRangeEnd = 168499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004BCC RID: 19404 RVA: 0x0017107C File Offset: 0x0016F27C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168499, XrefRangeEnd = 168515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x001710B0 File Offset: 0x0016F2B0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VolumetricLightTracker() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VolumetricLightTracker>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VolumetricLightTracker.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x00024602 File Offset: 0x00022802
		public VolumetricLightTracker(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001693 RID: 5779
		// (get) Token: 0x06004BCF RID: 19407 RVA: 0x001710EC File Offset: 0x0016F2EC
		// (set) Token: 0x06004BD0 RID: 19408 RVA: 0x0002460B File Offset: 0x0002280B
		public unsafe bool Override
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Override);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Override)) = value;
			}
		}

		// Token: 0x17001694 RID: 5780
		// (get) Token: 0x06004BD1 RID: 19409 RVA: 0x00171114 File Offset: 0x0016F314
		// (set) Token: 0x06004BD2 RID: 19410 RVA: 0x00024626 File Offset: 0x00022826
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x17001695 RID: 5781
		// (get) Token: 0x06004BD3 RID: 19411 RVA: 0x0017113C File Offset: 0x0016F33C
		// (set) Token: 0x06004BD4 RID: 19412 RVA: 0x00024641 File Offset: 0x00022841
		public unsafe Light light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x0017116C File Offset: 0x0016F36C
		// (set) Token: 0x06004BD6 RID: 19414 RVA: 0x00024660 File Offset: 0x00022860
		public unsafe OptimizedLight optimizedLight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<OptimizedLight>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_optimizedLight), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06004BD7 RID: 19415 RVA: 0x0017119C File Offset: 0x0016F39C
		// (set) Token: 0x06004BD8 RID: 19416 RVA: 0x0002467F File Offset: 0x0002287F
		public unsafe VolumetricLightBeamSD beam
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_beam);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricLightBeamSD>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_beam), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06004BD9 RID: 19417 RVA: 0x001711CC File Offset: 0x0016F3CC
		// (set) Token: 0x06004BDA RID: 19418 RVA: 0x0002469E File Offset: 0x0002289E
		public unsafe VolumetricDustParticles dust
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_dust);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VolumetricDustParticles>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VolumetricLightTracker.NativeFieldInfoPtr_dust), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003307 RID: 13063
		private static readonly IntPtr NativeFieldInfoPtr_Override;

		// Token: 0x04003308 RID: 13064
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x04003309 RID: 13065
		private static readonly IntPtr NativeFieldInfoPtr_light;

		// Token: 0x0400330A RID: 13066
		private static readonly IntPtr NativeFieldInfoPtr_optimizedLight;

		// Token: 0x0400330B RID: 13067
		private static readonly IntPtr NativeFieldInfoPtr_beam;

		// Token: 0x0400330C RID: 13068
		private static readonly IntPtr NativeFieldInfoPtr_dust;

		// Token: 0x0400330D RID: 13069
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x0400330E RID: 13070
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x0400330F RID: 13071
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
