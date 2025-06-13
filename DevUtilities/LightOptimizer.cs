using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x0200047B RID: 1147
	public class LightOptimizer : MonoBehaviour
	{
		// Token: 0x06006297 RID: 25239 RVA: 0x001C4548 File Offset: 0x001C2748
		// Note: this type is marked as 'beforefieldinit'.
		static LightOptimizer()
		{
			Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "LightOptimizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr);
			LightOptimizer.NativeFieldInfoPtr_LightsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "LightsEnabled");
			LightOptimizer.NativeFieldInfoPtr_activationZones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "activationZones");
			LightOptimizer.NativeFieldInfoPtr_viewPoints = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "viewPoints");
			LightOptimizer.NativeFieldInfoPtr_checkRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "checkRange");
			LightOptimizer.NativeFieldInfoPtr_lights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, "lights");
			LightOptimizer.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675934);
			LightOptimizer.NativeMethodInfoPtr_FixedUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675935);
			LightOptimizer.NativeMethodInfoPtr_ApplyLights_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675936);
			LightOptimizer.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675937);
			LightOptimizer.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675938);
			LightOptimizer.NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675939);
			LightOptimizer.NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675940);
			LightOptimizer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr, 100675941);
		}

		// Token: 0x06006298 RID: 25240 RVA: 0x001C467C File Offset: 0x001C287C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204011, XrefRangeEnd = 204015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006299 RID: 25241 RVA: 0x001C46B0 File Offset: 0x001C28B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204015, XrefRangeEnd = 204040, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_FixedUpdate_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600629A RID: 25242 RVA: 0x001C46E4 File Offset: 0x001C28E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 204041, RefRangeEnd = 204042, XrefRangeStart = 204040, XrefRangeEnd = 204041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_ApplyLights_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600629B RID: 25243 RVA: 0x001C4718 File Offset: 0x001C2918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204042, XrefRangeEnd = 204075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PointInCameraView(Vector3 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x001C4764 File Offset: 0x001C2964
		[CallerCount(0)]
		public unsafe bool Is01(float a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_Is01_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x001C47B0 File Offset: 0x001C29B0
		[CallerCount(0)]
		public unsafe void LightsEnabled_True()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600629E RID: 25246 RVA: 0x001C47E4 File Offset: 0x001C29E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 88449, RefRangeEnd = 88450, XrefRangeStart = 88449, XrefRangeEnd = 88450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LightsEnabled_False()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600629F RID: 25247 RVA: 0x001C4818 File Offset: 0x001C2A18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 204075, XrefRangeEnd = 204076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightOptimizer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightOptimizer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightOptimizer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060062A0 RID: 25248 RVA: 0x0002E642 File Offset: 0x0002C842
		public LightOptimizer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D70 RID: 7536
		// (get) Token: 0x060062A1 RID: 25249 RVA: 0x001C4854 File Offset: 0x001C2A54
		// (set) Token: 0x060062A2 RID: 25250 RVA: 0x0002E64B File Offset: 0x0002C84B
		public unsafe bool LightsEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_LightsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_LightsEnabled)) = value;
			}
		}

		// Token: 0x17001D71 RID: 7537
		// (get) Token: 0x060062A3 RID: 25251 RVA: 0x001C487C File Offset: 0x001C2A7C
		// (set) Token: 0x060062A4 RID: 25252 RVA: 0x0002E666 File Offset: 0x0002C866
		public unsafe Il2CppReferenceArray<BoxCollider> activationZones
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_activationZones);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<BoxCollider>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_activationZones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D72 RID: 7538
		// (get) Token: 0x060062A5 RID: 25253 RVA: 0x001C48AC File Offset: 0x001C2AAC
		// (set) Token: 0x060062A6 RID: 25254 RVA: 0x0002E685 File Offset: 0x0002C885
		public unsafe Il2CppReferenceArray<Transform> viewPoints
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_viewPoints);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_viewPoints), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D73 RID: 7539
		// (get) Token: 0x060062A7 RID: 25255 RVA: 0x001C48DC File Offset: 0x001C2ADC
		// (set) Token: 0x060062A8 RID: 25256 RVA: 0x0002E6A4 File Offset: 0x0002C8A4
		public unsafe float checkRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_checkRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_checkRange)) = value;
			}
		}

		// Token: 0x17001D74 RID: 7540
		// (get) Token: 0x060062A9 RID: 25257 RVA: 0x001C4904 File Offset: 0x001C2B04
		// (set) Token: 0x060062AA RID: 25258 RVA: 0x0002E6BF File Offset: 0x0002C8BF
		public unsafe Il2CppReferenceArray<OptimizedLight> lights
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_lights);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<OptimizedLight>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightOptimizer.NativeFieldInfoPtr_lights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400434E RID: 17230
		private static readonly IntPtr NativeFieldInfoPtr_LightsEnabled;

		// Token: 0x0400434F RID: 17231
		private static readonly IntPtr NativeFieldInfoPtr_activationZones;

		// Token: 0x04004350 RID: 17232
		private static readonly IntPtr NativeFieldInfoPtr_viewPoints;

		// Token: 0x04004351 RID: 17233
		private static readonly IntPtr NativeFieldInfoPtr_checkRange;

		// Token: 0x04004352 RID: 17234
		private static readonly IntPtr NativeFieldInfoPtr_lights;

		// Token: 0x04004353 RID: 17235
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04004354 RID: 17236
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Public_Void_0;

		// Token: 0x04004355 RID: 17237
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLights_Public_Void_0;

		// Token: 0x04004356 RID: 17238
		private static readonly IntPtr NativeMethodInfoPtr_PointInCameraView_Public_Boolean_Vector3_0;

		// Token: 0x04004357 RID: 17239
		private static readonly IntPtr NativeMethodInfoPtr_Is01_Public_Boolean_Single_0;

		// Token: 0x04004358 RID: 17240
		private static readonly IntPtr NativeMethodInfoPtr_LightsEnabled_True_Public_Void_0;

		// Token: 0x04004359 RID: 17241
		private static readonly IntPtr NativeMethodInfoPtr_LightsEnabled_False_Public_Void_0;

		// Token: 0x0400435A RID: 17242
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
