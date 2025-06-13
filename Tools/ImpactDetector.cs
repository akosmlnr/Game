using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000560 RID: 1376
	public class ImpactDetector : MonoBehaviour
	{
		// Token: 0x0600791D RID: 31005 RVA: 0x0020FDBC File Offset: 0x0020DFBC
		// Note: this type is marked as 'beforefieldinit'.
		static ImpactDetector()
		{
			Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ImpactDetector");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr);
			ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, "DestroyScriptOnImpact");
			ImpactDetector.NativeFieldInfoPtr_onImpact = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, "onImpact");
			ImpactDetector.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, 100678658);
			ImpactDetector.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr, 100678659);
		}

		// Token: 0x0600791E RID: 31006 RVA: 0x0020FE3C File Offset: 0x0020E03C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235230, XrefRangeEnd = 235235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCollisionEnter(Collision collision)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(collision);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactDetector.NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600791F RID: 31007 RVA: 0x0020FE80 File Offset: 0x0020E080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235235, XrefRangeEnd = 235241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ImpactDetector() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ImpactDetector>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ImpactDetector.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x000391E9 File Offset: 0x000373E9
		public ImpactDetector(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002470 RID: 9328
		// (get) Token: 0x06007921 RID: 31009 RVA: 0x0020FEBC File Offset: 0x0020E0BC
		// (set) Token: 0x06007922 RID: 31010 RVA: 0x000391F2 File Offset: 0x000373F2
		public unsafe bool DestroyScriptOnImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_DestroyScriptOnImpact)) = value;
			}
		}

		// Token: 0x17002471 RID: 9329
		// (get) Token: 0x06007923 RID: 31011 RVA: 0x0020FEE4 File Offset: 0x0020E0E4
		// (set) Token: 0x06007924 RID: 31012 RVA: 0x0003920D File Offset: 0x0003740D
		public unsafe UnityEvent onImpact
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_onImpact);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ImpactDetector.NativeFieldInfoPtr_onImpact), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052B3 RID: 21171
		private static readonly IntPtr NativeFieldInfoPtr_DestroyScriptOnImpact;

		// Token: 0x040052B4 RID: 21172
		private static readonly IntPtr NativeFieldInfoPtr_onImpact;

		// Token: 0x040052B5 RID: 21173
		private static readonly IntPtr NativeMethodInfoPtr_OnCollisionEnter_Private_Void_Collision_0;

		// Token: 0x040052B6 RID: 21174
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
