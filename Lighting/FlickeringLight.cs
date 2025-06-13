using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003D5 RID: 981
	public class FlickeringLight : MonoBehaviour
	{
		// Token: 0x06004B5F RID: 19295 RVA: 0x0016FDD4 File Offset: 0x0016DFD4
		// Note: this type is marked as 'beforefieldinit'.
		static FlickeringLight()
		{
			Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "FlickeringLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr);
			FlickeringLight.NativeFieldInfoPtr_minIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "minIntensity");
			FlickeringLight.NativeFieldInfoPtr_maxIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "maxIntensity");
			FlickeringLight.NativeFieldInfoPtr_enableColorShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "enableColorShift");
			FlickeringLight.NativeFieldInfoPtr_minColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "minColor");
			FlickeringLight.NativeFieldInfoPtr_maxColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "maxColor");
			FlickeringLight.NativeFieldInfoPtr_flickerSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "flickerSpeed");
			FlickeringLight.NativeFieldInfoPtr_lightSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "lightSource");
			FlickeringLight.NativeFieldInfoPtr_targetIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "targetIntensity");
			FlickeringLight.NativeFieldInfoPtr_targetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, "targetColor");
			FlickeringLight.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672731);
			FlickeringLight.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672732);
			FlickeringLight.NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672733);
			FlickeringLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr, 100672734);
		}

		// Token: 0x06004B60 RID: 19296 RVA: 0x0016FF08 File Offset: 0x0016E108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168227, XrefRangeEnd = 168232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x0016FF3C File Offset: 0x0016E13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168232, XrefRangeEnd = 168242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x0016FF70 File Offset: 0x0016E170
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168245, RefRangeEnd = 168247, XrefRangeStart = 168242, XrefRangeEnd = 168245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateTargetValues()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x0016FFA4 File Offset: 0x0016E1A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168247, XrefRangeEnd = 168248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FlickeringLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FlickeringLight>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FlickeringLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x000241ED File Offset: 0x000223ED
		public FlickeringLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x06004B65 RID: 19301 RVA: 0x0016FFE0 File Offset: 0x0016E1E0
		// (set) Token: 0x06004B66 RID: 19302 RVA: 0x000241F6 File Offset: 0x000223F6
		public unsafe float minIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minIntensity)) = value;
			}
		}

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x06004B67 RID: 19303 RVA: 0x00170008 File Offset: 0x0016E208
		// (set) Token: 0x06004B68 RID: 19304 RVA: 0x00024211 File Offset: 0x00022411
		public unsafe float maxIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxIntensity)) = value;
			}
		}

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x06004B69 RID: 19305 RVA: 0x00170030 File Offset: 0x0016E230
		// (set) Token: 0x06004B6A RID: 19306 RVA: 0x0002422C File Offset: 0x0002242C
		public unsafe bool enableColorShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_enableColorShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_enableColorShift)) = value;
			}
		}

		// Token: 0x17001673 RID: 5747
		// (get) Token: 0x06004B6B RID: 19307 RVA: 0x00170058 File Offset: 0x0016E258
		// (set) Token: 0x06004B6C RID: 19308 RVA: 0x00024247 File Offset: 0x00022447
		public unsafe Color minColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_minColor)) = value;
			}
		}

		// Token: 0x17001674 RID: 5748
		// (get) Token: 0x06004B6D RID: 19309 RVA: 0x00170080 File Offset: 0x0016E280
		// (set) Token: 0x06004B6E RID: 19310 RVA: 0x00024262 File Offset: 0x00022462
		public unsafe Color maxColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_maxColor)) = value;
			}
		}

		// Token: 0x17001675 RID: 5749
		// (get) Token: 0x06004B6F RID: 19311 RVA: 0x001700A8 File Offset: 0x0016E2A8
		// (set) Token: 0x06004B70 RID: 19312 RVA: 0x0002427D File Offset: 0x0002247D
		public unsafe float flickerSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_flickerSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_flickerSpeed)) = value;
			}
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06004B71 RID: 19313 RVA: 0x001700D0 File Offset: 0x0016E2D0
		// (set) Token: 0x06004B72 RID: 19314 RVA: 0x00024298 File Offset: 0x00022498
		public unsafe Light lightSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_lightSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_lightSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06004B73 RID: 19315 RVA: 0x00170100 File Offset: 0x0016E300
		// (set) Token: 0x06004B74 RID: 19316 RVA: 0x000242B7 File Offset: 0x000224B7
		public unsafe float targetIntensity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetIntensity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetIntensity)) = value;
			}
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06004B75 RID: 19317 RVA: 0x00170128 File Offset: 0x0016E328
		// (set) Token: 0x06004B76 RID: 19318 RVA: 0x000242D2 File Offset: 0x000224D2
		public unsafe Color targetColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FlickeringLight.NativeFieldInfoPtr_targetColor)) = value;
			}
		}

		// Token: 0x040032CB RID: 13003
		private static readonly IntPtr NativeFieldInfoPtr_minIntensity;

		// Token: 0x040032CC RID: 13004
		private static readonly IntPtr NativeFieldInfoPtr_maxIntensity;

		// Token: 0x040032CD RID: 13005
		private static readonly IntPtr NativeFieldInfoPtr_enableColorShift;

		// Token: 0x040032CE RID: 13006
		private static readonly IntPtr NativeFieldInfoPtr_minColor;

		// Token: 0x040032CF RID: 13007
		private static readonly IntPtr NativeFieldInfoPtr_maxColor;

		// Token: 0x040032D0 RID: 13008
		private static readonly IntPtr NativeFieldInfoPtr_flickerSpeed;

		// Token: 0x040032D1 RID: 13009
		private static readonly IntPtr NativeFieldInfoPtr_lightSource;

		// Token: 0x040032D2 RID: 13010
		private static readonly IntPtr NativeFieldInfoPtr_targetIntensity;

		// Token: 0x040032D3 RID: 13011
		private static readonly IntPtr NativeFieldInfoPtr_targetColor;

		// Token: 0x040032D4 RID: 13012
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040032D5 RID: 13013
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040032D6 RID: 13014
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTargetValues_Private_Void_0;

		// Token: 0x040032D7 RID: 13015
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
