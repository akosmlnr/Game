using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.StationFramework
{
	// Token: 0x020005B0 RID: 1456
	public class LiquidVolumeCollider : MonoBehaviour
	{
		// Token: 0x06007F34 RID: 32564 RVA: 0x00223EA8 File Offset: 0x002220A8
		// Note: this type is marked as 'beforefieldinit'.
		static LiquidVolumeCollider()
		{
			Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.StationFramework", "LiquidVolumeCollider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr);
			LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, "LiquidContainer");
			LiquidVolumeCollider.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, 100679323);
			LiquidVolumeCollider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr, 100679324);
		}

		// Token: 0x06007F35 RID: 32565 RVA: 0x00223F14 File Offset: 0x00222114
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 241540, XrefRangeEnd = 241548, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeCollider.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F36 RID: 32566 RVA: 0x00223F48 File Offset: 0x00222148
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LiquidVolumeCollider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LiquidVolumeCollider>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LiquidVolumeCollider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x0003C272 File Offset: 0x0003A472
		public LiquidVolumeCollider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002646 RID: 9798
		// (get) Token: 0x06007F38 RID: 32568 RVA: 0x00223F84 File Offset: 0x00222184
		// (set) Token: 0x06007F39 RID: 32569 RVA: 0x0003C27B File Offset: 0x0003A47B
		public unsafe LiquidContainer LiquidContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LiquidContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LiquidVolumeCollider.NativeFieldInfoPtr_LiquidContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005697 RID: 22167
		private static readonly IntPtr NativeFieldInfoPtr_LiquidContainer;

		// Token: 0x04005698 RID: 22168
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04005699 RID: 22169
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
