using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppTMPro;

namespace Il2CppScheduleOne.ExtendedComponents
{
	// Token: 0x0200041C RID: 1052
	public class GameInputField : TMP_InputField
	{
		// Token: 0x0600567D RID: 22141 RVA: 0x001961D8 File Offset: 0x001943D8
		// Note: this type is marked as 'beforefieldinit'.
		static GameInputField()
		{
			Il2CppClassPointerStore<GameInputField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ExtendedComponents", "GameInputField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInputField>.NativeClassPtr);
			GameInputField.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100674126);
			GameInputField.NativeMethodInfoPtr_EditStart_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100674127);
			GameInputField.NativeMethodInfoPtr_EndEdit_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100674128);
			GameInputField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInputField>.NativeClassPtr, 100674129);
		}

		// Token: 0x0600567E RID: 22142 RVA: 0x00196258 File Offset: 0x00194458
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184607, XrefRangeEnd = 184625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInputField.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x00196294 File Offset: 0x00194494
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184625, XrefRangeEnd = 184629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EditStart(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInputField.NativeMethodInfoPtr_EditStart_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005680 RID: 22144 RVA: 0x001962D8 File Offset: 0x001944D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184629, XrefRangeEnd = 184633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEdit(string newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newVal);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInputField.NativeMethodInfoPtr_EndEdit_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x0019631C File Offset: 0x0019451C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 184633, XrefRangeEnd = 184637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameInputField() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInputField>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInputField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005682 RID: 22146 RVA: 0x00029533 File Offset: 0x00027733
		public GameInputField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04003A82 RID: 14978
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04003A83 RID: 14979
		private static readonly IntPtr NativeMethodInfoPtr_EditStart_Private_Void_String_0;

		// Token: 0x04003A84 RID: 14980
		private static readonly IntPtr NativeMethodInfoPtr_EndEdit_Private_Void_String_0;

		// Token: 0x04003A85 RID: 14981
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
