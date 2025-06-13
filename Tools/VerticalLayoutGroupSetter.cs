using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000576 RID: 1398
	public class VerticalLayoutGroupSetter : MonoBehaviour
	{
		// Token: 0x06007A24 RID: 31268 RVA: 0x00212B60 File Offset: 0x00210D60
		// Note: this type is marked as 'beforefieldinit'.
		static VerticalLayoutGroupSetter()
		{
			Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "VerticalLayoutGroupSetter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr);
			VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, "LeftSpacing");
			VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, "layoutGroup");
			VerticalLayoutGroupSetter.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678747);
			VerticalLayoutGroupSetter.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678748);
			VerticalLayoutGroupSetter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr, 100678749);
		}

		// Token: 0x06007A25 RID: 31269 RVA: 0x00212BF4 File Offset: 0x00210DF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236037, XrefRangeEnd = 236041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A26 RID: 31270 RVA: 0x00212C28 File Offset: 0x00210E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 236041, XrefRangeEnd = 236050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x00212C5C File Offset: 0x00210E5C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VerticalLayoutGroupSetter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VerticalLayoutGroupSetter>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VerticalLayoutGroupSetter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x00039A3E File Offset: 0x00037C3E
		public VerticalLayoutGroupSetter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170024B6 RID: 9398
		// (get) Token: 0x06007A29 RID: 31273 RVA: 0x00212C98 File Offset: 0x00210E98
		// (set) Token: 0x06007A2A RID: 31274 RVA: 0x00039A47 File Offset: 0x00037C47
		public unsafe float LeftSpacing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_LeftSpacing)) = value;
			}
		}

		// Token: 0x170024B7 RID: 9399
		// (get) Token: 0x06007A2B RID: 31275 RVA: 0x00212CC0 File Offset: 0x00210EC0
		// (set) Token: 0x06007A2C RID: 31276 RVA: 0x00039A62 File Offset: 0x00037C62
		public unsafe VerticalLayoutGroup layoutGroup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VerticalLayoutGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VerticalLayoutGroupSetter.NativeFieldInfoPtr_layoutGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005349 RID: 21321
		private static readonly IntPtr NativeFieldInfoPtr_LeftSpacing;

		// Token: 0x0400534A RID: 21322
		private static readonly IntPtr NativeFieldInfoPtr_layoutGroup;

		// Token: 0x0400534B RID: 21323
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400534C RID: 21324
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400534D RID: 21325
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
