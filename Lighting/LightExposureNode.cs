using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Lighting
{
	// Token: 0x020003D6 RID: 982
	public class LightExposureNode : MonoBehaviour
	{
		// Token: 0x06004B77 RID: 19319 RVA: 0x00170150 File Offset: 0x0016E350
		// Note: this type is marked as 'beforefieldinit'.
		static LightExposureNode()
		{
			Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Lighting", "LightExposureNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr);
			LightExposureNode.NativeFieldInfoPtr_ambientExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, "ambientExposure");
			LightExposureNode.NativeFieldInfoPtr_sources = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, "sources");
			LightExposureNode.NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672735);
			LightExposureNode.NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672736);
			LightExposureNode.NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672737);
			LightExposureNode.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672738);
			LightExposureNode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr, 100672739);
		}

		// Token: 0x06004B78 RID: 19320 RVA: 0x0017020C File Offset: 0x0016E40C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168272, RefRangeEnd = 168274, XrefRangeStart = 168248, XrefRangeEnd = 168272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetTotalExposure(out float growSpeedMultiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = &growSpeedMultiplier;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004B79 RID: 19321 RVA: 0x00170258 File Offset: 0x0016E458
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168284, RefRangeEnd = 168285, XrefRangeStart = 168274, XrefRangeEnd = 168284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddSource(UsableLightSource source, float lightAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lightAmount;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B7A RID: 19322 RVA: 0x001702A8 File Offset: 0x0016E4A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 168289, RefRangeEnd = 168290, XrefRangeStart = 168285, XrefRangeEnd = 168289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveSource(UsableLightSource source)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B7B RID: 19323 RVA: 0x001702EC File Offset: 0x0016E4EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168290, XrefRangeEnd = 168295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDrawGizmos()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B7C RID: 19324 RVA: 0x00170320 File Offset: 0x0016E520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168295, XrefRangeEnd = 168303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightExposureNode() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightExposureNode>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightExposureNode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B7D RID: 19325 RVA: 0x000242ED File Offset: 0x000224ED
		public LightExposureNode(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x06004B7E RID: 19326 RVA: 0x0017035C File Offset: 0x0016E55C
		// (set) Token: 0x06004B7F RID: 19327 RVA: 0x000242F6 File Offset: 0x000224F6
		public unsafe float ambientExposure
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_ambientExposure);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_ambientExposure)) = value;
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x06004B80 RID: 19328 RVA: 0x00170384 File Offset: 0x0016E584
		// (set) Token: 0x06004B81 RID: 19329 RVA: 0x00024311 File Offset: 0x00022511
		public unsafe Dictionary<UsableLightSource, float> sources
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_sources);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<UsableLightSource, float>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightExposureNode.NativeFieldInfoPtr_sources), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032D8 RID: 13016
		private static readonly IntPtr NativeFieldInfoPtr_ambientExposure;

		// Token: 0x040032D9 RID: 13017
		private static readonly IntPtr NativeFieldInfoPtr_sources;

		// Token: 0x040032DA RID: 13018
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalExposure_Public_Single_byref_Single_0;

		// Token: 0x040032DB RID: 13019
		private static readonly IntPtr NativeMethodInfoPtr_AddSource_Public_Void_UsableLightSource_Single_0;

		// Token: 0x040032DC RID: 13020
		private static readonly IntPtr NativeMethodInfoPtr_RemoveSource_Public_Void_UsableLightSource_0;

		// Token: 0x040032DD RID: 13021
		private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;

		// Token: 0x040032DE RID: 13022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
