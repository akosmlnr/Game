using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000482 RID: 1154
	public class OptimizedLight : MonoBehaviour
	{
		// Token: 0x0600632B RID: 25387 RVA: 0x001C644C File Offset: 0x001C464C
		// Note: this type is marked as 'beforefieldinit'.
		static OptimizedLight()
		{
			Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "OptimizedLight");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr);
			OptimizedLight.NativeFieldInfoPtr_Enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "Enabled");
			OptimizedLight.NativeFieldInfoPtr_DisabledForOptimization = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "DisabledForOptimization");
			OptimizedLight.NativeFieldInfoPtr_MaxDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "MaxDistance");
			OptimizedLight.NativeFieldInfoPtr__Light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "_Light");
			OptimizedLight.NativeFieldInfoPtr_culled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "culled");
			OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, "maxDistanceSquared");
			OptimizedLight.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675996);
			OptimizedLight.NativeMethodInfoPtr_Start_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675997);
			OptimizedLight.NativeMethodInfoPtr_OnDestroy_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675998);
			OptimizedLight.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100675999);
			OptimizedLight.NativeMethodInfoPtr_UpdateCull_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100676000);
			OptimizedLight.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100676001);
			OptimizedLight.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100676002);
			OptimizedLight.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr, 100676003);
		}

		// Token: 0x0600632C RID: 25388 RVA: 0x001C6594 File Offset: 0x001C4794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205064, XrefRangeEnd = 205068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptimizedLight.NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600632D RID: 25389 RVA: 0x001C65D0 File Offset: 0x001C47D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205068, XrefRangeEnd = 205092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_Start_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600632E RID: 25390 RVA: 0x001C6604 File Offset: 0x001C4804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205092, XrefRangeEnd = 205106, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_OnDestroy_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600632F RID: 25391 RVA: 0x001C6638 File Offset: 0x001C4838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205106, XrefRangeEnd = 205112, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OptimizedLight.NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006330 RID: 25392 RVA: 0x001C6674 File Offset: 0x001C4874
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205112, XrefRangeEnd = 205128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCull()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_UpdateCull_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006331 RID: 25393 RVA: 0x001C66A8 File Offset: 0x001C48A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref enabled;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006332 RID: 25394 RVA: 0x001C66E8 File Offset: 0x001C48E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205128, XrefRangeEnd = 205129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OptimizedLight() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OptimizedLight>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006333 RID: 25395 RVA: 0x001C6724 File Offset: 0x001C4924
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205170, RefRangeEnd = 205171, XrefRangeStart = 205129, XrefRangeEnd = 205170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OptimizedLight.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006334 RID: 25396 RVA: 0x0002EA2D File Offset: 0x0002CC2D
		public OptimizedLight(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DA1 RID: 7585
		// (get) Token: 0x06006335 RID: 25397 RVA: 0x001C6758 File Offset: 0x001C4958
		// (set) Token: 0x06006336 RID: 25398 RVA: 0x0002EA36 File Offset: 0x0002CC36
		public unsafe bool Enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_Enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_Enabled)) = value;
			}
		}

		// Token: 0x17001DA2 RID: 7586
		// (get) Token: 0x06006337 RID: 25399 RVA: 0x001C6780 File Offset: 0x001C4980
		// (set) Token: 0x06006338 RID: 25400 RVA: 0x0002EA51 File Offset: 0x0002CC51
		public unsafe bool DisabledForOptimization
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_DisabledForOptimization);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_DisabledForOptimization)) = value;
			}
		}

		// Token: 0x17001DA3 RID: 7587
		// (get) Token: 0x06006339 RID: 25401 RVA: 0x001C67A8 File Offset: 0x001C49A8
		// (set) Token: 0x0600633A RID: 25402 RVA: 0x0002EA6C File Offset: 0x0002CC6C
		public unsafe float MaxDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_MaxDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_MaxDistance)) = value;
			}
		}

		// Token: 0x17001DA4 RID: 7588
		// (get) Token: 0x0600633B RID: 25403 RVA: 0x001C67D0 File Offset: 0x001C49D0
		// (set) Token: 0x0600633C RID: 25404 RVA: 0x0002EA87 File Offset: 0x0002CC87
		public unsafe Light _Light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__Light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr__Light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA5 RID: 7589
		// (get) Token: 0x0600633D RID: 25405 RVA: 0x001C6800 File Offset: 0x001C4A00
		// (set) Token: 0x0600633E RID: 25406 RVA: 0x0002EAA6 File Offset: 0x0002CCA6
		public unsafe bool culled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_culled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_culled)) = value;
			}
		}

		// Token: 0x17001DA6 RID: 7590
		// (get) Token: 0x0600633F RID: 25407 RVA: 0x001C6828 File Offset: 0x001C4A28
		// (set) Token: 0x06006340 RID: 25408 RVA: 0x0002EAC1 File Offset: 0x0002CCC1
		public unsafe float maxDistanceSquared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OptimizedLight.NativeFieldInfoPtr_maxDistanceSquared)) = value;
			}
		}

		// Token: 0x040043AF RID: 17327
		private static readonly IntPtr NativeFieldInfoPtr_Enabled;

		// Token: 0x040043B0 RID: 17328
		private static readonly IntPtr NativeFieldInfoPtr_DisabledForOptimization;

		// Token: 0x040043B1 RID: 17329
		private static readonly IntPtr NativeFieldInfoPtr_MaxDistance;

		// Token: 0x040043B2 RID: 17330
		private static readonly IntPtr NativeFieldInfoPtr__Light;

		// Token: 0x040043B3 RID: 17331
		private static readonly IntPtr NativeFieldInfoPtr_culled;

		// Token: 0x040043B4 RID: 17332
		private static readonly IntPtr NativeFieldInfoPtr_maxDistanceSquared;

		// Token: 0x040043B5 RID: 17333
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_New_Void_0;

		// Token: 0x040043B6 RID: 17334
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_1;

		// Token: 0x040043B7 RID: 17335
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_1;

		// Token: 0x040043B8 RID: 17336
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Virtual_New_Void_0;

		// Token: 0x040043B9 RID: 17337
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCull_Private_Void_1;

		// Token: 0x040043BA RID: 17338
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Public_Void_Boolean_0;

		// Token: 0x040043BB RID: 17339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040043BC RID: 17340
		private static readonly IntPtr NativeMethodInfoPtr_Method_Private_Void_0;
	}
}
