using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Messaging
{
	// Token: 0x02000397 RID: 919
	[System.Serializable]
	public class Response : Il2CppSystem.Object
	{
		// Token: 0x0600471A RID: 18202 RVA: 0x0015F788 File Offset: 0x0015D988
		// Note: this type is marked as 'beforefieldinit'.
		static Response()
		{
			Il2CppClassPointerStore<Response>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Messaging", "Response");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Response>.NativeClassPtr);
			Response.NativeFieldInfoPtr_text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "text");
			Response.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "label");
			Response.NativeFieldInfoPtr_callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "callback");
			Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Response>.NativeClassPtr, "disableDefaultResponseBehaviour");
			Response.NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Response>.NativeClassPtr, 100672122);
			Response.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Response>.NativeClassPtr, 100672123);
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x0015F830 File Offset: 0x0015DA30
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 162394, RefRangeEnd = 162399, XrefRangeStart = 162390, XrefRangeEnd = 162394, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response(string _text, string _label, Il2CppSystem.Action _callback = null, bool _disableDefaultResponseBehaviour = false) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Response>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(_text);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(_label);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_callback);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _disableDefaultResponseBehaviour;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Response.NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x0015F8B0 File Offset: 0x0015DAB0
		[CallerCount(2576)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Response() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Response>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Response.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x00022686 File Offset: 0x00020886
		public Response(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x0600471E RID: 18206 RVA: 0x0015F8EC File Offset: 0x0015DAEC
		// (set) Token: 0x0600471F RID: 18207 RVA: 0x0002268F File Offset: 0x0002088F
		public unsafe string text
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_text);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_text), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06004720 RID: 18208 RVA: 0x0015F914 File Offset: 0x0015DB14
		// (set) Token: 0x06004721 RID: 18209 RVA: 0x000226AE File Offset: 0x000208AE
		public unsafe string label
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06004722 RID: 18210 RVA: 0x0015F93C File Offset: 0x0015DB3C
		// (set) Token: 0x06004723 RID: 18211 RVA: 0x000226CD File Offset: 0x000208CD
		public unsafe Il2CppSystem.Action callback
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_callback);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_callback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x06004724 RID: 18212 RVA: 0x0015F96C File Offset: 0x0015DB6C
		// (set) Token: 0x06004725 RID: 18213 RVA: 0x000226EC File Offset: 0x000208EC
		public unsafe bool disableDefaultResponseBehaviour
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Response.NativeFieldInfoPtr_disableDefaultResponseBehaviour)) = value;
			}
		}

		// Token: 0x04002FB0 RID: 12208
		private static readonly System.IntPtr NativeFieldInfoPtr_text;

		// Token: 0x04002FB1 RID: 12209
		private static readonly System.IntPtr NativeFieldInfoPtr_label;

		// Token: 0x04002FB2 RID: 12210
		private static readonly System.IntPtr NativeFieldInfoPtr_callback;

		// Token: 0x04002FB3 RID: 12211
		private static readonly System.IntPtr NativeFieldInfoPtr_disableDefaultResponseBehaviour;

		// Token: 0x04002FB4 RID: 12212
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Action_Boolean_0;

		// Token: 0x04002FB5 RID: 12213
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
