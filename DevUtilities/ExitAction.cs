using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000499 RID: 1177
	public class ExitAction : Il2CppSystem.Object
	{
		// Token: 0x060064A3 RID: 25763 RVA: 0x001CAEF4 File Offset: 0x001C90F4
		// Note: this type is marked as 'beforefieldinit'.
		static ExitAction()
		{
			Il2CppClassPointerStore<ExitAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "ExitAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExitAction>.NativeClassPtr);
			ExitAction.NativeFieldInfoPtr_exitType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, "exitType");
			ExitAction.NativeFieldInfoPtr_used = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, "used");
			ExitAction.NativeMethodInfoPtr_get_Used_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100676154);
			ExitAction.NativeMethodInfoPtr_set_Used_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100676155);
			ExitAction.NativeMethodInfoPtr_Use_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100676156);
			ExitAction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExitAction>.NativeClassPtr, 100676157);
		}

		// Token: 0x17001E1A RID: 7706
		// (get) Token: 0x060064A4 RID: 25764 RVA: 0x001CAF9C File Offset: 0x001C919C
		// (set) Token: 0x060064A5 RID: 25765 RVA: 0x001CAFD8 File Offset: 0x001C91D8
		public unsafe bool Used
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr_get_Used_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(65)]
			[CachedScanResults(RefRangeStart = 206945, RefRangeEnd = 207010, XrefRangeStart = 206945, XrefRangeEnd = 206945, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr_set_Used_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060064A6 RID: 25766 RVA: 0x001CB018 File Offset: 0x001C9218
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 207010, RefRangeEnd = 207011, XrefRangeStart = 207010, XrefRangeEnd = 207010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Use()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr_Use_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064A7 RID: 25767 RVA: 0x001CB04C File Offset: 0x001C924C
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExitAction() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExitAction>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExitAction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060064A8 RID: 25768 RVA: 0x0002F583 File Offset: 0x0002D783
		public ExitAction(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E18 RID: 7704
		// (get) Token: 0x060064A9 RID: 25769 RVA: 0x001CB088 File Offset: 0x001C9288
		// (set) Token: 0x060064AA RID: 25770 RVA: 0x0002F58C File Offset: 0x0002D78C
		public unsafe ExitType exitType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_exitType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_exitType)) = value;
			}
		}

		// Token: 0x17001E19 RID: 7705
		// (get) Token: 0x060064AB RID: 25771 RVA: 0x001CB0B0 File Offset: 0x001C92B0
		// (set) Token: 0x060064AC RID: 25772 RVA: 0x0002F5A7 File Offset: 0x0002D7A7
		public unsafe bool used
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_used);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ExitAction.NativeFieldInfoPtr_used)) = value;
			}
		}

		// Token: 0x040044A9 RID: 17577
		private static readonly System.IntPtr NativeFieldInfoPtr_exitType;

		// Token: 0x040044AA RID: 17578
		private static readonly System.IntPtr NativeFieldInfoPtr_used;

		// Token: 0x040044AB RID: 17579
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Used_Public_get_Boolean_0;

		// Token: 0x040044AC RID: 17580
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Used_Public_set_Void_Boolean_0;

		// Token: 0x040044AD RID: 17581
		private static readonly System.IntPtr NativeMethodInfoPtr_Use_Public_Void_0;

		// Token: 0x040044AE RID: 17582
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
