using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Properties.MixMaps
{
	// Token: 0x020001FE RID: 510
	[Serializable]
	public class MixerMap : ScriptableObject
	{
		// Token: 0x060028F8 RID: 10488 RVA: 0x000F4F18 File Offset: 0x000F3118
		// Note: this type is marked as 'beforefieldinit'.
		static MixerMap()
		{
			Il2CppClassPointerStore<MixerMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Properties.MixMaps", "MixerMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixerMap>.NativeClassPtr);
			MixerMap.NativeFieldInfoPtr_MapRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, "MapRadius");
			MixerMap.NativeFieldInfoPtr_Effects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, "Effects");
			MixerMap.NativeMethodInfoPtr_GetEffectAtPoint_Public_MixerMapEffect_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, 100667956);
			MixerMap.NativeMethodInfoPtr_GetEffect_Public_MixerMapEffect_Property_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, 100667957);
			MixerMap.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixerMap>.NativeClassPtr, 100667958);
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x000F4FAC File Offset: 0x000F31AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 121960, RefRangeEnd = 121961, XrefRangeStart = 121942, XrefRangeEnd = 121960, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapEffect GetEffectAtPoint(Vector2 point)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref point;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMap.NativeMethodInfoPtr_GetEffectAtPoint_Public_MixerMapEffect_Vector2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixerMapEffect>(intPtr2) : null;
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x000F4FF8 File Offset: 0x000F31F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 121961, XrefRangeEnd = 121972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMapEffect GetEffect(Property property)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(property);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMap.NativeMethodInfoPtr_GetEffect_Public_MixerMapEffect_Property_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixerMapEffect>(intPtr2) : null;
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x000F5048 File Offset: 0x000F3248
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 92196, RefRangeEnd = 92208, XrefRangeStart = 92196, XrefRangeEnd = 92208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixerMap() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixerMap>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixerMap.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x00016276 File Offset: 0x00014476
		public MixerMap(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x060028FD RID: 10493 RVA: 0x000F5084 File Offset: 0x000F3284
		// (set) Token: 0x060028FE RID: 10494 RVA: 0x0001627F File Offset: 0x0001447F
		public unsafe float MapRadius
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_MapRadius);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_MapRadius)) = value;
			}
		}

		// Token: 0x17000D97 RID: 3479
		// (get) Token: 0x060028FF RID: 10495 RVA: 0x000F50AC File Offset: 0x000F32AC
		// (set) Token: 0x06002900 RID: 10496 RVA: 0x0001629A File Offset: 0x0001449A
		public unsafe List<MixerMapEffect> Effects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_Effects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MixerMapEffect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixerMap.NativeFieldInfoPtr_Effects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001B32 RID: 6962
		private static readonly IntPtr NativeFieldInfoPtr_MapRadius;

		// Token: 0x04001B33 RID: 6963
		private static readonly IntPtr NativeFieldInfoPtr_Effects;

		// Token: 0x04001B34 RID: 6964
		private static readonly IntPtr NativeMethodInfoPtr_GetEffectAtPoint_Public_MixerMapEffect_Vector2_0;

		// Token: 0x04001B35 RID: 6965
		private static readonly IntPtr NativeMethodInfoPtr_GetEffect_Public_MixerMapEffect_Property_0;

		// Token: 0x04001B36 RID: 6966
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
