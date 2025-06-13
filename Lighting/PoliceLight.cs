using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003D8 RID: 984
	public class PoliceLight : MonoBehaviour
	{
		// Token: 0x06004B92 RID: 19346 RVA: 0x001706B0 File Offset: 0x0016E8B0
		// Note: this type is marked as 'beforefieldinit'.
		static PoliceLight()
		{
			Il2CppClassPointerStore<PoliceLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "PoliceLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr);
			PoliceLight.NativeFieldInfoPtr_IsOn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "IsOn");
			PoliceLight.NativeFieldInfoPtr_RedMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedMeshes");
			PoliceLight.NativeFieldInfoPtr_BlueMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueMeshes");
			PoliceLight.NativeFieldInfoPtr_RedLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedLights");
			PoliceLight.NativeFieldInfoPtr_BlueLights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueLights");
			PoliceLight.NativeFieldInfoPtr_Siren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "Siren");
			PoliceLight.NativeFieldInfoPtr_CycleDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "CycleDuration");
			PoliceLight.NativeFieldInfoPtr_RedOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedOffMat");
			PoliceLight.NativeFieldInfoPtr_RedOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedOnMat");
			PoliceLight.NativeFieldInfoPtr_BlueOffMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueOffMat");
			PoliceLight.NativeFieldInfoPtr_BlueOnMat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueOnMat");
			PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "RedBrightnessCurve");
			PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "BlueBrightnessCurve");
			PoliceLight.NativeFieldInfoPtr_LightBrightness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "LightBrightness");
			PoliceLight.NativeFieldInfoPtr_cycleRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "cycleRoutine");
			PoliceLight.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672746);
			PoliceLight.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672747);
			PoliceLight.NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672748);
			PoliceLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, 100672749);
		}

		// Token: 0x06004B93 RID: 19347 RVA: 0x0017085C File Offset: 0x0016EA5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsOn(bool isOn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref isOn;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B94 RID: 19348 RVA: 0x0017089C File Offset: 0x0016EA9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168365, XrefRangeEnd = 168367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B95 RID: 19349 RVA: 0x001708D0 File Offset: 0x0016EAD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168367, XrefRangeEnd = 168372, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator CycleCoroutine()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x06004B96 RID: 19350 RVA: 0x00170910 File Offset: 0x0016EB10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168372, XrefRangeEnd = 168373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PoliceLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B97 RID: 19351 RVA: 0x000243A9 File Offset: 0x000225A9
		public PoliceLight(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06004B98 RID: 19352 RVA: 0x0017094C File Offset: 0x0016EB4C
		// (set) Token: 0x06004B99 RID: 19353 RVA: 0x000243B2 File Offset: 0x000225B2
		public unsafe bool IsOn
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_IsOn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_IsOn)) = value;
			}
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06004B9A RID: 19354 RVA: 0x00170974 File Offset: 0x0016EB74
		// (set) Token: 0x06004B9B RID: 19355 RVA: 0x000243CD File Offset: 0x000225CD
		public unsafe Il2CppReferenceArray<MeshRenderer> RedMeshes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedMeshes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06004B9C RID: 19356 RVA: 0x001709A4 File Offset: 0x0016EBA4
		// (set) Token: 0x06004B9D RID: 19357 RVA: 0x000243EC File Offset: 0x000225EC
		public unsafe Il2CppReferenceArray<MeshRenderer> BlueMeshes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueMeshes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06004B9E RID: 19358 RVA: 0x001709D4 File Offset: 0x0016EBD4
		// (set) Token: 0x06004B9F RID: 19359 RVA: 0x0002440B File Offset: 0x0002260B
		public unsafe Il2CppReferenceArray<OptimizedLight> RedLights
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedLights);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x06004BA0 RID: 19360 RVA: 0x00170A04 File Offset: 0x0016EC04
		// (set) Token: 0x06004BA1 RID: 19361 RVA: 0x0002442A File Offset: 0x0002262A
		public unsafe Il2CppReferenceArray<OptimizedLight> BlueLights
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueLights);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueLights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x06004BA2 RID: 19362 RVA: 0x00170A34 File Offset: 0x0016EC34
		// (set) Token: 0x06004BA3 RID: 19363 RVA: 0x00024449 File Offset: 0x00022649
		public unsafe AudioSourceController Siren
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_Siren);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_Siren), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x06004BA4 RID: 19364 RVA: 0x00170A64 File Offset: 0x0016EC64
		// (set) Token: 0x06004BA5 RID: 19365 RVA: 0x00024468 File Offset: 0x00022668
		public unsafe float CycleDuration
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_CycleDuration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_CycleDuration)) = value;
			}
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x06004BA6 RID: 19366 RVA: 0x00170A8C File Offset: 0x0016EC8C
		// (set) Token: 0x06004BA7 RID: 19367 RVA: 0x00024483 File Offset: 0x00022683
		public unsafe Material RedOffMat
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOffMat);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x06004BA8 RID: 19368 RVA: 0x00170ABC File Offset: 0x0016ECBC
		// (set) Token: 0x06004BA9 RID: 19369 RVA: 0x000244A2 File Offset: 0x000226A2
		public unsafe Material RedOnMat
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOnMat);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06004BAA RID: 19370 RVA: 0x00170AEC File Offset: 0x0016ECEC
		// (set) Token: 0x06004BAB RID: 19371 RVA: 0x000244C1 File Offset: 0x000226C1
		public unsafe Material BlueOffMat
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOffMat);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOffMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06004BAC RID: 19372 RVA: 0x00170B1C File Offset: 0x0016ED1C
		// (set) Token: 0x06004BAD RID: 19373 RVA: 0x000244E0 File Offset: 0x000226E0
		public unsafe Material BlueOnMat
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOnMat);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueOnMat), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06004BAE RID: 19374 RVA: 0x00170B4C File Offset: 0x0016ED4C
		// (set) Token: 0x06004BAF RID: 19375 RVA: 0x000244FF File Offset: 0x000226FF
		public unsafe AnimationCurve RedBrightnessCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_RedBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06004BB0 RID: 19376 RVA: 0x00170B7C File Offset: 0x0016ED7C
		// (set) Token: 0x06004BB1 RID: 19377 RVA: 0x0002451E File Offset: 0x0002271E
		public unsafe AnimationCurve BlueBrightnessCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_BlueBrightnessCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06004BB2 RID: 19378 RVA: 0x00170BAC File Offset: 0x0016EDAC
		// (set) Token: 0x06004BB3 RID: 19379 RVA: 0x0002453D File Offset: 0x0002273D
		public unsafe float LightBrightness
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_LightBrightness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_LightBrightness)) = value;
			}
		}

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x06004BB4 RID: 19380 RVA: 0x00170BD4 File Offset: 0x0016EDD4
		// (set) Token: 0x06004BB5 RID: 19381 RVA: 0x00024558 File Offset: 0x00022758
		public unsafe Coroutine cycleRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_cycleRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight.NativeFieldInfoPtr_cycleRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032E9 RID: 13033
		private static readonly System.IntPtr NativeFieldInfoPtr_IsOn;

		// Token: 0x040032EA RID: 13034
		private static readonly System.IntPtr NativeFieldInfoPtr_RedMeshes;

		// Token: 0x040032EB RID: 13035
		private static readonly System.IntPtr NativeFieldInfoPtr_BlueMeshes;

		// Token: 0x040032EC RID: 13036
		private static readonly System.IntPtr NativeFieldInfoPtr_RedLights;

		// Token: 0x040032ED RID: 13037
		private static readonly System.IntPtr NativeFieldInfoPtr_BlueLights;

		// Token: 0x040032EE RID: 13038
		private static readonly System.IntPtr NativeFieldInfoPtr_Siren;

		// Token: 0x040032EF RID: 13039
		private static readonly System.IntPtr NativeFieldInfoPtr_CycleDuration;

		// Token: 0x040032F0 RID: 13040
		private static readonly System.IntPtr NativeFieldInfoPtr_RedOffMat;

		// Token: 0x040032F1 RID: 13041
		private static readonly System.IntPtr NativeFieldInfoPtr_RedOnMat;

		// Token: 0x040032F2 RID: 13042
		private static readonly System.IntPtr NativeFieldInfoPtr_BlueOffMat;

		// Token: 0x040032F3 RID: 13043
		private static readonly System.IntPtr NativeFieldInfoPtr_BlueOnMat;

		// Token: 0x040032F4 RID: 13044
		private static readonly System.IntPtr NativeFieldInfoPtr_RedBrightnessCurve;

		// Token: 0x040032F5 RID: 13045
		private static readonly System.IntPtr NativeFieldInfoPtr_BlueBrightnessCurve;

		// Token: 0x040032F6 RID: 13046
		private static readonly System.IntPtr NativeFieldInfoPtr_LightBrightness;

		// Token: 0x040032F7 RID: 13047
		private static readonly System.IntPtr NativeFieldInfoPtr_cycleRoutine;

		// Token: 0x040032F8 RID: 13048
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsOn_Public_Void_Boolean_0;

		// Token: 0x040032F9 RID: 13049
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040032FA RID: 13050
		private static readonly System.IntPtr NativeMethodInfoPtr_CycleCoroutine_Protected_IEnumerator_0;

		// Token: 0x040032FB RID: 13051
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009D1 RID: 2513
		[ObfuscatedName("ScheduleOne.Lighting.PoliceLight+<CycleCoroutine>d__17")]
		public sealed class _CycleCoroutine_d__17 : Il2CppSystem.Object
		{
			// Token: 0x0600CF41 RID: 53057 RVA: 0x00324000 File Offset: 0x00322200
			// Note: this type is marked as 'beforefieldinit'.
			static _CycleCoroutine_d__17()
			{
				Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PoliceLight>.NativeClassPtr, "<CycleCoroutine>d__17");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr);
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>1__state");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>2__current");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<>4__this");
				PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, "<time>5__2");
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672750);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672751);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672752);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672753);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672754);
				PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr, 100672755);
			}

			// Token: 0x0600CF42 RID: 53058 RVA: 0x003240F4 File Offset: 0x003222F4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _CycleCoroutine_d__17(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PoliceLight._CycleCoroutine_d__17>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF43 RID: 53059 RVA: 0x0032413C File Offset: 0x0032233C
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF44 RID: 53060 RVA: 0x00324170 File Offset: 0x00322370
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168328, XrefRangeEnd = 168360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x17004047 RID: 16455
			// (get) Token: 0x0600CF45 RID: 53061 RVA: 0x003241AC File Offset: 0x003223AC
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CF46 RID: 53062 RVA: 0x003241EC File Offset: 0x003223EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168360, XrefRangeEnd = 168365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x17004048 RID: 16456
			// (get) Token: 0x0600CF47 RID: 53063 RVA: 0x00324220 File Offset: 0x00322420
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PoliceLight._CycleCoroutine_d__17.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600CF48 RID: 53064 RVA: 0x00064745 File Offset: 0x00062945
			public _CycleCoroutine_d__17(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004043 RID: 16451
			// (get) Token: 0x0600CF49 RID: 53065 RVA: 0x00324260 File Offset: 0x00322460
			// (set) Token: 0x0600CF4A RID: 53066 RVA: 0x0006474E File Offset: 0x0006294E
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x17004044 RID: 16452
			// (get) Token: 0x0600CF4B RID: 53067 RVA: 0x00324288 File Offset: 0x00322488
			// (set) Token: 0x0600CF4C RID: 53068 RVA: 0x00064769 File Offset: 0x00062969
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004045 RID: 16453
			// (get) Token: 0x0600CF4D RID: 53069 RVA: 0x003242B8 File Offset: 0x003224B8
			// (set) Token: 0x0600CF4E RID: 53070 RVA: 0x00064788 File Offset: 0x00062988
			public unsafe PoliceLight __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PoliceLight>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004046 RID: 16454
			// (get) Token: 0x0600CF4F RID: 53071 RVA: 0x003242E8 File Offset: 0x003224E8
			// (set) Token: 0x0600CF50 RID: 53072 RVA: 0x000647A7 File Offset: 0x000629A7
			public unsafe float _time_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PoliceLight._CycleCoroutine_d__17.NativeFieldInfoPtr__time_5__2)) = value;
				}
			}

			// Token: 0x04008C3D RID: 35901
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008C3E RID: 35902
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008C3F RID: 35903
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008C40 RID: 35904
			private static readonly System.IntPtr NativeFieldInfoPtr__time_5__2;

			// Token: 0x04008C41 RID: 35905
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008C42 RID: 35906
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C43 RID: 35907
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008C44 RID: 35908
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008C45 RID: 35909
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008C46 RID: 35910
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
