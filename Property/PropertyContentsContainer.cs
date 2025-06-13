using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Property
{
	// Token: 0x02000532 RID: 1330
	public class PropertyContentsContainer : MonoBehaviour
	{
		// Token: 0x0600753F RID: 30015 RVA: 0x00201E9C File Offset: 0x0020009C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyContentsContainer()
		{
			Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Property", "PropertyContentsContainer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr);
			PropertyContentsContainer.NativeFieldInfoPtr_Property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr, "Property");
			PropertyContentsContainer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr, 100678113);
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x00201EF4 File Offset: 0x002000F4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyContentsContainer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyContentsContainer>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyContentsContainer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007541 RID: 30017 RVA: 0x00037853 File Offset: 0x00035A53
		public PropertyContentsContainer(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x06007542 RID: 30018 RVA: 0x00201F30 File Offset: 0x00200130
		// (set) Token: 0x06007543 RID: 30019 RVA: 0x0003785C File Offset: 0x00035A5C
		public unsafe Property Property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContentsContainer.NativeFieldInfoPtr_Property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Property>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyContentsContainer.NativeFieldInfoPtr_Property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400500C RID: 20492
		private static readonly IntPtr NativeFieldInfoPtr_Property;

		// Token: 0x0400500D RID: 20493
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
