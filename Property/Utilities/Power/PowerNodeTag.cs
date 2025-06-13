using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Property.Utilities.Power
{
	// Token: 0x0200053D RID: 1341
	public class PowerNodeTag : MonoBehaviour
	{
		// Token: 0x06007662 RID: 30306 RVA: 0x00205F98 File Offset: 0x00204198
		// Note: this type is marked as 'beforefieldinit'.
		static PowerNodeTag()
		{
			Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property.Utilities.Power", "PowerNodeTag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr);
			PowerNodeTag.NativeFieldInfoPtr_powerNode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr, "powerNode");
			PowerNodeTag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr, 100678273);
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x00205FF0 File Offset: 0x002041F0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PowerNodeTag() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PowerNodeTag>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PowerNodeTag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007664 RID: 30308 RVA: 0x00037FC6 File Offset: 0x000361C6
		public PowerNodeTag(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x06007665 RID: 30309 RVA: 0x0020602C File Offset: 0x0020422C
		// (set) Token: 0x06007666 RID: 30310 RVA: 0x00037FCF File Offset: 0x000361CF
		public unsafe PowerNode powerNode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNodeTag.NativeFieldInfoPtr_powerNode);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PowerNode>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PowerNodeTag.NativeFieldInfoPtr_powerNode), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040050D8 RID: 20696
		private static readonly IntPtr NativeFieldInfoPtr_powerNode;

		// Token: 0x040050D9 RID: 20697
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
