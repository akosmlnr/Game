using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vision
{
	// Token: 0x0200017D RID: 381
	public class LightVisibilityAffector : MonoBehaviour
	{
		// Token: 0x06001E2C RID: 7724 RVA: 0x000D138C File Offset: 0x000CF58C
		// Note: this type is marked as 'beforefieldinit'.
		static LightVisibilityAffector()
		{
			Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vision", "LightVisibilityAffector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr);
			LightVisibilityAffector.NativeFieldInfoPtr_PointLightEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "PointLightEffect");
			LightVisibilityAffector.NativeFieldInfoPtr_SpotLightEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "SpotLightEffect");
			LightVisibilityAffector.NativeFieldInfoPtr_EffectMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "EffectMultiplier");
			LightVisibilityAffector.NativeFieldInfoPtr_uniquenessCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "uniquenessCode");
			LightVisibilityAffector.NativeFieldInfoPtr_updateDistanceThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "updateDistanceThreshold");
			LightVisibilityAffector.NativeFieldInfoPtr_light = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "light");
			LightVisibilityAffector.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, "attribute");
			LightVisibilityAffector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666762);
			LightVisibilityAffector.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666763);
			LightVisibilityAffector.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666764);
			LightVisibilityAffector.NativeMethodInfoPtr_UpdateVisibility_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666765);
			LightVisibilityAffector.NativeMethodInfoPtr_UpdateAttribute_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666766);
			LightVisibilityAffector.NativeMethodInfoPtr_ClearAttribute_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666767);
			LightVisibilityAffector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr, 100666768);
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x000D14D4 File Offset: 0x000CF6D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109825, XrefRangeEnd = 109849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightVisibilityAffector.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x000D1510 File Offset: 0x000CF710
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109849, XrefRangeEnd = 109878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayerSpawned()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_PlayerSpawned_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x000D1544 File Offset: 0x000CF744
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109878, XrefRangeEnd = 109896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x000D1578 File Offset: 0x000CF778
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109896, XrefRangeEnd = 109957, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateVisibility()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), LightVisibilityAffector.NativeMethodInfoPtr_UpdateVisibility_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x000D15B4 File Offset: 0x000CF7B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109962, RefRangeEnd = 109963, XrefRangeStart = 109957, XrefRangeEnd = 109962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateAttribute(float visibity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref visibity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_UpdateAttribute_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x000D15F4 File Offset: 0x000CF7F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109971, RefRangeEnd = 109972, XrefRangeStart = 109963, XrefRangeEnd = 109971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr_ClearAttribute_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x000D1628 File Offset: 0x000CF828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109972, XrefRangeEnd = 109977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightVisibilityAffector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightVisibilityAffector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightVisibilityAffector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00010EE0 File Offset: 0x0000F0E0
		public LightVisibilityAffector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x000D1664 File Offset: 0x000CF864
		// (set) Token: 0x06001E36 RID: 7734 RVA: 0x00010EE9 File Offset: 0x0000F0E9
		public unsafe static float PointLightEffect
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LightVisibilityAffector.NativeFieldInfoPtr_PointLightEffect, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightVisibilityAffector.NativeFieldInfoPtr_PointLightEffect, (void*)(&value));
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x000D1680 File Offset: 0x000CF880
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x00010EF7 File Offset: 0x0000F0F7
		public unsafe static float SpotLightEffect
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(LightVisibilityAffector.NativeFieldInfoPtr_SpotLightEffect, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(LightVisibilityAffector.NativeFieldInfoPtr_SpotLightEffect, (void*)(&value));
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x000D169C File Offset: 0x000CF89C
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x00010F05 File Offset: 0x0000F105
		public unsafe float EffectMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_EffectMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_EffectMultiplier)) = value;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x000D16C4 File Offset: 0x000CF8C4
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x00010F20 File Offset: 0x0000F120
		public unsafe string uniquenessCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_uniquenessCode);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_uniquenessCode), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x000D16EC File Offset: 0x000CF8EC
		// (set) Token: 0x06001E3E RID: 7742 RVA: 0x00010F3F File Offset: 0x0000F13F
		public unsafe int updateDistanceThreshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_updateDistanceThreshold);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_updateDistanceThreshold)) = value;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x000D1714 File Offset: 0x000CF914
		// (set) Token: 0x06001E40 RID: 7744 RVA: 0x00010F5A File Offset: 0x0000F15A
		public unsafe Light light
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_light);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Light>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_light), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x000D1744 File Offset: 0x000CF944
		// (set) Token: 0x06001E42 RID: 7746 RVA: 0x00010F79 File Offset: 0x0000F179
		public unsafe VisibilityAttribute attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisibilityAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightVisibilityAffector.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001413 RID: 5139
		private static readonly IntPtr NativeFieldInfoPtr_PointLightEffect;

		// Token: 0x04001414 RID: 5140
		private static readonly IntPtr NativeFieldInfoPtr_SpotLightEffect;

		// Token: 0x04001415 RID: 5141
		private static readonly IntPtr NativeFieldInfoPtr_EffectMultiplier;

		// Token: 0x04001416 RID: 5142
		private static readonly IntPtr NativeFieldInfoPtr_uniquenessCode;

		// Token: 0x04001417 RID: 5143
		private static readonly IntPtr NativeFieldInfoPtr_updateDistanceThreshold;

		// Token: 0x04001418 RID: 5144
		private static readonly IntPtr NativeFieldInfoPtr_light;

		// Token: 0x04001419 RID: 5145
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x0400141A RID: 5146
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x0400141B RID: 5147
		private static readonly IntPtr NativeMethodInfoPtr_PlayerSpawned_Private_Void_0;

		// Token: 0x0400141C RID: 5148
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x0400141D RID: 5149
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisibility_Protected_Virtual_New_Void_0;

		// Token: 0x0400141E RID: 5150
		private static readonly IntPtr NativeMethodInfoPtr_UpdateAttribute_Private_Void_Single_0;

		// Token: 0x0400141F RID: 5151
		private static readonly IntPtr NativeMethodInfoPtr_ClearAttribute_Private_Void_0;

		// Token: 0x04001420 RID: 5152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
